using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWithoutUIDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool isError = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show("App running.");
            MessageBox.Show("In progress.........");
            if (isError)
            {
                MessageBox.Show("Unexpectedd error");
                return;
            }
            else
                //Application.Exit();
                Application.Run(new Process());
                MessageBox.Show("no error.program continue the process till end");
            MessageBox.Show("end of process.");
        }
    }
}
