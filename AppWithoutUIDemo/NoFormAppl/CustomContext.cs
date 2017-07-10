using NoFormAppl.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoFormAppl
{
    /// <summary>
    /// Application specific context used to create application's main standard loop without form.
    /// </summary>
    /// <see cref="http://msdn.microsoft.com/en-us/library/ms157901.aspx" />
    public class CustomContext : ApplicationContext
    {
        /// <summary>
        /// Used to display application icon in taskbar and interact with user.
        /// </summary>
        private NotifyIcon trayIcon;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomContext" /> class.
        /// </summary>
        public CustomContext()
        {
            this.BuildNotifyIconInstance();
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
            }
            else
            {
                MessageBox.Show("Program execution aborted...");
            }
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Builds the tray NotifyIcon instance.
        /// </summary>
        private void BuildNotifyIconInstance()
        {
            // tray icon initialization
            this.trayIcon = new NotifyIcon()
            {
                Text = "Application with no form",
                Icon = Resources.TrayIcon
            };

            // creates a context menu with one Exit item.
            var contextMenu = new ContextMenuStrip();
            var exitMenuItem = new ToolStripMenuItem("Exit");
            contextMenu.Items.Add(exitMenuItem);
            exitMenuItem.Click += this.Exit;

            // we assign the context menu to the tray icon object
            this.trayIcon.ContextMenuStrip = contextMenu;

            // makes the tray icon visible
            this.trayIcon.Visible = true;
        }

        /// <summary>
        /// Handles the Exit menu item click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            trayIcon.Visible = false;

            Application.Exit();
        }
    }
}
