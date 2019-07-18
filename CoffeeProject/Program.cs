using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm lgForm = new LoginForm();

            if (lgForm.ShowDialog() == DialogResult.OK)
            {
                string username = LoginForm.Username;
                Application.Run(new MainCoffee(username));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
