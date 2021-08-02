using System;
using System.Drawing;
using System.Windows.Forms;
using VolandoBoy_printer.Properties;
using Timer = System.Windows.Forms.Timer;

namespace VolandoBoy_printer
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        public VolandoBoy volandoBoy;
        public Printer printer;


        public void ShowError(string error, int duration = 3)
        {
            label_error.Text = error;
            label_error.Visible = true;

            var t = new Timer();
            t.Interval = duration * 1000;
            t.Tick += (s, e) =>
            {
                label_error.Visible = false;
                t.Stop();
            };
            t.Start();
        }

        public void ActualizeStatus(string text)
        {
            ActualizeStatus(text, Color.White);
        }
        public void ActualizeStatus(string text, Color color)
        {
            label_status.Text = "Status: " + text;
            label_status.ForeColor = color;
        }

        public void Log(string text, string color = "white")
        {
            if (label_log.Text == "log line") label_log.Text = null;

            label_log.Text = text + "\n" + label_log.Text;
        }
        public void Log(VolandoBoy.Command command)
        {
            Log("[" + command.time_init + "]  " + command.tag + "  |  " + command.restaurantPrice() + "€");
        }

        public bool DuplicateTickets()
        {
            return check_duplicate.Checked;
        }

        // private -----------------------------

        private void OnLogin()
        {
            label_rest_name.Text = volandoBoy.restaurant.name;

            panel_login.Visible = false;
            panel_pooling.Visible = true;

            if(printer != null && volandoBoy.loggedIn) volandoBoy.StartPooling();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            volandoBoy = new VolandoBoy();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters) select_printer.Items.Add(printer);
            select_printer.SelectedItem = Settings.Default.printerName;

            check_duplicate.Checked = Settings.Default.duplicate_tickets;
            label_log.Text = null;

            if (volandoBoy.Login(Settings.Default.email, Settings.Default.password)) OnLogin();
            else panel_login.Visible = true;
        }



        // buttons --------------------------------------------------
        private void button_login_Click(object sender, EventArgs e)
        {
            if (volandoBoy.Login(input_email.Text, input_password.Text)) OnLogin();
            else
            {
                ShowError("Correo electrónico o contraseña incorrectos");

                input_email.Text = null;
                input_password.Text = null;

                input_email.Focus();
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            volandoBoy.Logout();
            panel_pooling.Visible = false;
            panel_login.Visible = true;
        }

        private void button_test_printer_Click(object sender, EventArgs e)
        {
            if(printer == null) ShowError("No printer selected", 5);
            else printer.PrintTest();
        }

        private void check_duplicate_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.duplicate_tickets = check_duplicate.Checked;
            Settings.Default.Save();
        }

        private void select_printer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.printerName = select_printer.SelectedItem.ToString();
            Settings.Default.Save();

            if(Settings.Default.printerName.Length > 0)
            {
                printer = new Printer(Settings.Default.printerName);
                if (volandoBoy.loggedIn) volandoBoy.StartPooling();
            }
            else{

                volandoBoy.StopPooling();
                printer = null;
                ShowError("No printer selected", 5);
                ActualizeStatus("Stopped, no printer", Color.Red);
            }
        }
    }
}
