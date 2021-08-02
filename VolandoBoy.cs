using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using VolandoBoy_printer.Properties;
using Timer = System.Windows.Forms.Timer;

namespace VolandoBoy_printer
{

    public class VolandoBoy
    {

        private Dictionary<string, string> credentials;

        const string volandoBoy_printerGateway_uri = "https://volandoboy.es/php/gateway/printer.php";

        public class Restaurant
        {
            public int id;
            public string name;

            public Restaurant()
            {

            }
        }

        public class Command
        {
            public struct Line
            {
                public struct Name
                {
                    public string en, ca, es;
                }
                public struct Ingredient
                {
                    public int id;
                    public string family;
                    public string type;
                    public float? price;
                    public Name name;
                }
                public struct Product
                {
                    public class Variant
                    {
                        public int id;
                        public Name name;
                        public string family;
                    }

                    public int? id;
                    public Name name;
                    public float price;
                    public Variant variant;
                }

                public int id;
                public int id_command;
                public float price;
                public string comment;
                public Product product;
                public List<Ingredient> changed_ingredients;

                public List<Ingredient> removedIngredients() {

                    return changed_ingredients.FindAll(ing => ing.type == "REMOVABLE");
                }
                public List<Ingredient> addedIngredients() {

                    return changed_ingredients.FindAll(ing => ing.type == "EXTRA");
                }
            }

            public class Coupon
            {
                public int id;
                public int? id_restaurant;
                public string code;
                public string town;
                public int value;
                public string type;
                public string applies;
            }

            public int id;
            public int? id_user;
            public int id_restaurant;
            public int? id_flyer;
            public string tag;
            public float price;
            public float discount;
            public Coupon coupon;
            public float tip;
            public int payed;
            public string payment_id;
            public string state;
            public float delivery_price;
            public string town;
            public string comment;
            public string time_init;

            public List<Line> lines;

            public Command(){}

            public float restaurantPrice() {

                float adjustedPrice = this.price - this.delivery_price - this.tip;
                if (this.coupon == null || this.coupon.id_restaurant == null) adjustedPrice += this.discount;

                return adjustedPrice;
            }
        }

        public Restaurant restaurant;
        public bool loggedIn = false;

        private List<Command> printedCommands;

        private readonly int pool_interval = 15;
        private Timer pool_timer;

        public VolandoBoy()
        {
            Console.WriteLine("Volando Boy object created");

            printedCommands = new List<Command>();

            pool_timer = new Timer();
            pool_timer.Interval = pool_interval * 1000;
            pool_timer.Tick += (s, e) => { Pool(); };
        }

        public bool Login(string email, string password)
        {
            Dictionary<string, string> credentials = new Dictionary<string, string> { { "email", email }, { "password", password } };
            string res = Program.HTTP_post(volandoBoy_printerGateway_uri, credentials);

            if (res != null && res.Length > 0)
            {
                loggedIn = true;
                this.credentials = credentials;

                Settings.Default.email = email;
                Settings.Default.password = password;
                Settings.Default.Save();

                restaurant = JsonConvert.DeserializeObject<Restaurant>(res);

                return true;
            }
            else return false;
        }
        public void Logout()
        {
            loggedIn = false;
            credentials = null;

            Settings.Default.email = null;
            Settings.Default.password = null;
            Settings.Default.Save();

            restaurant = null;

            StopPooling();
        }

        public void StartPooling()
        {
            Pool();
            if (!pool_timer.Enabled) pool_timer.Start();
        }
        public void StopPooling()
        {
            if (pool_timer.Enabled) pool_timer.Stop();
        }

        private void Pool()
        {
            List<Command> newCommands = GetCommandsToConfirm();

            if (newCommands != null)
            {
                foreach (Command comm in newCommands)
                {
                    if (!printedCommands.Exists(c => c.id == comm.id))
                    {
                        Program.Form_main().printer.PrintCommand(comm);
                        if (Program.Form_main().DuplicateTickets()) Program.Form_main().printer.PrintCommand(comm);

                        Program.Form_main().Log(comm);

                        printedCommands.Add(comm);
                    }
                }

                Program.Form_main().ActualizeStatus("Ultima actualización " + DateTime.Now.ToString("H:mm:ss"), Color.LimeGreen);
            }
        }

        private List<Command> GetCommandsToConfirm()
        {
            string res = Program.HTTP_get(volandoBoy_printerGateway_uri, credentials);

            if (res != null)
            {
                List<Command> commands = null;

                try
                {
                    commands = JsonConvert.DeserializeObject<List<Command>>(res);
                }
                catch (Exception)
                {
                    Program.Form_main().ShowError("Bad Command list json parse");
                }

                return commands;
            }
            else return null;
        }
    }
}
