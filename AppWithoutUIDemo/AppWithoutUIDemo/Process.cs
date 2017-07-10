using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWithoutUIDemo
{
    public class Process: ApplicationContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomContext" /> class.
        /// </summary>
        public Process()
        {
            ExecuteProgram();
        }

        private void ExecuteProgram()
        {
            MessageBox.Show("Program execution started...");
            for (int i = 0; i <= 5; i++)
            {
                MessageBox.Show("value :" + i);
            }
            DialogResult dr = MessageBox.Show("Contiue execution ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                for (int i = 6; i <= 8; i++)
                {
                    MessageBox.Show("value :" + i);
                }
                MessageBox.Show("Program execution over...");
                //return;
            }
            else
            {
                MessageBox.Show("Program execution aborted...");
            }
            //Application.Exit();
            System.Environment.Exit(0);
        }
    }
}
