using System;
using System.Windows.Forms;

namespace arayuz
{
    static class Program
    {
        public static string databasecon;


        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            databasecon = "server=localhost;userid=root;password=12345;database=prolab";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
