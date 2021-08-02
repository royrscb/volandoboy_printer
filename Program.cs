using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace VolandoBoy_printer
{
    static class Program
    {
        public static Form_main Form_main()
        {
            return Application.OpenForms["Form_main"] as Form_main;
        }

        public static string HTTP_get(string uri)
        {
            try
            {
                var client = new HttpClient();
                
                var response = client.GetAsync(uri).Result;

                if (response.IsSuccessStatusCode) return response.Content.ReadAsStringAsync().Result;
                else
                {
                    Form_main().ShowError("Error with GET: " + response.StatusCode);
                    Console.Beep();
                    return null;
                }
            }
            catch (Exception e)
            {
                Form_main().ShowError("NO INTERNET: " + e.Message);
                Console.Beep();
                return null;
            }
        }
        public static string HTTP_get(string uri, Dictionary<string, string> data)
        {
            string urlParams = string.Join("&", data.Keys.Select(k => k + '=' + data[k]).ToArray());

            return HTTP_get(uri + '?' + urlParams);
        }
        public static string HTTP_post(string uri, Dictionary<string, string> data)
        {
            try {

                var client = new HttpClient();
                
                HttpContent content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                var response = client.PostAsync(uri, content).Result;

                if (response.IsSuccessStatusCode) return response.Content.ReadAsStringAsync().Result;
                else
                {
                    Form_main().ShowError("Error with POST: "+response.StatusCode);
                    Console.Beep();
                    return null;
                }
            }
            catch (Exception e)
            {
                Form_main().ShowError("NO INTERNET: " + e.Message);
                Console.Beep();
                return null;
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_main());
        }

    }

}
