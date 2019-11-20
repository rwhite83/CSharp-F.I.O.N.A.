using System;

using System.Drawing;
using System.Windows.Forms;

namespace FIONA
{
    public partial class Application : Form

    {
        FtpServer test_server;
        private bool _connectionStarted;
        private string sorry = "Sorry about that...";
        private string notice = "Just so you know...";

        /// <summary>
        /// a property to keep track of whether or not the system is currently sharing
        /// </summary>
        public bool connectionStarted
        {
            get
            {
                return _connectionStarted;
            }
            set
            {
                _connectionStarted = value;
            }
        }

        /// <summary>
        /// entry point of the program (application constructor)
        /// sets connection status to false
        /// </summary>
        public Application()
        {
            InitializeComponent();
            _connectionStarted = false;
        }

        /// <summary>
        /// Alerts the user that they are bypassing a future login system when they pass through
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string help = "A Login System is currently in development.  You are being forwarded in as a generic user.";
            MessageBox.Show(help, notice);
            panelMainMenu.BringToFront();
        }

        /// <summary>
        /// Alerts the user that this feature is not currently available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnectMain_Click(object sender, EventArgs e)
        {
            string help = "Sorry, this feature still in development.  Check back soon!";
            MessageBox.Show(help, sorry);
            panelMainMenu.BringToFront();
            // below is what this button is supposed to do when feature built
            //panelConnect.BringToFront();
        }

        /// <summary>
        /// brings share panel to front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShareMain_Click(object sender, EventArgs e)
        {
            panelShare.BringToFront();
        }

        /// <summary>
        /// brings main menu panel to front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelMainMenu.BringToFront();
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            panelEntry.BringToFront();
        }

        /// <summary>
        /// this function should handle login events, but presently just passes user through to the next panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            buttonLogin_Click(sender, e);
            //////////////////////////////////////////////////////////////////////////////
            // depracated until we develop more core functionality
            // I originally conceived this in Azure, but large costs forced me out
            // leaving in because most of the logic will be reusable
            //////////////////////////////////////////////////////////////////////////////
            
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=fiona.database.windows.net;Initial Catalog=FIONA_db;User ID=team_fiona;Password=#Wubbalubbadubdub;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            conn.Open();

            Console.WriteLine(conn.State);

            // i know i need to hash the password, this is early going
            //string new_username = username_txtbx.Text;
            //string new_password = password_txtbx.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            //SqlDataAdapter sda = new SqlDataAdapter();
            //adapter.InsertCommand = new SqlCommand("INSERT INTO users (username, password) VALUES ('" +  new_username + "', '" + new_password + "')", conn);
            adapter.InsertCommand.ExecuteNonQuery();
            */
        }

        /// <summary>
        /// handles starting and stopping serving
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonShareStartStop_Click(object sender, EventArgs e)
        {
            if (!_connectionStarted)
            {
                // checks if a folder has already been set
                if (Properties.Settings.Default.rootAppVar == "null")
                {
                    string help = "Whoops!  Please select a share folder before attempting to start sharing.";
                    MessageBox.Show(help, sorry);
                }
                // if not, instantializes FtpServer object and launces connection
                else
                {
                    Console.WriteLine("starting server");
                    test_server = new FtpServer(this, Properties.Settings.Default.rootAppVar);
                    if (!_connectionStarted)
                    {
                        buttonShareStartStop.ForeColor = Color.OrangeRed;
                        buttonShareStartStop.BackColor = Color.DarkRed;
                        labelStatus.Text = "Server Status: Online";
                        labelStatusConnectShare.Text = "Server Status: Online";
                        labelStatusConnectShare.ForeColor = Color.GreenYellow;
                        labelStatusConnectShare.BackColor = Color.ForestGreen;
                        labelStatus.ForeColor = Color.GreenYellow;
                        labelStatus.BackColor = Color.ForestGreen;
                        buttonShareStartStop.Text = "Stop Sharing";
                        _connectionStarted = true;
                        test_server.Start();
                    }
                }
            }
            // if server already started, clicking the button shuts down the server
            else
            {
                Console.WriteLine("shutting down server");
                test_server.Stop();
                buttonShareStartStop.BackColor = Color.ForestGreen;
                buttonShareStartStop.ForeColor = Color.GreenYellow;
                labelStatus.Text = "Server Status: Offline";
                labelStatusConnectShare.Text = "Server Status: Offline";
                labelStatusConnectShare.ForeColor = Color.OrangeRed;
                labelStatusConnectShare.BackColor = Color.DarkRed;
                labelStatus.ForeColor = Color.OrangeRed;
                labelStatus.BackColor = Color.DarkRed;
                buttonShareStartStop.Text = "Stop Sharing";
                _connectionStarted = false;
            }
        }

        /// <summary>
        /// sets or resets the folder which will be shared
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddShared_Click(object sender, EventArgs e)
        {
            // first checks if a folder is already set
            if (Properties.Settings.Default.rootAppVar != "null")
            {
                string folderAlreadySelectedMessage = "Sorry, currently only one folder can be shared.  Would you like to change your current share folder?";
                DialogResult dialogResult = MessageBox.Show(folderAlreadySelectedMessage, sorry, MessageBoxButtons.YesNo);
                // if user wishes to override existing share, sets new share folder
                if(dialogResult == DialogResult.Yes)
                {
                    FolderBrowserDialog rootPicker = new FolderBrowserDialog();
                    DialogResult result = rootPicker.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(rootPicker.SelectedPath))
                    {
                        Properties.Settings.Default.rootAppVar = rootPicker.SelectedPath;
                        labelFolderList.Text = Properties.Settings.Default.rootAppVar;
                    }
                }
            }
            // proceeds without interrruption if no folder already set
            else
            {
                FolderBrowserDialog rootPicker = new FolderBrowserDialog();
                DialogResult result = rootPicker.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(rootPicker.SelectedPath))
                {
                    Properties.Settings.Default.rootAppVar = rootPicker.SelectedPath;
                    labelFolderList.Text = Properties.Settings.Default.rootAppVar;
                }
            }
        }

        /// <summary>
        /// alerts user that the function they are trying to access is not yet developed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelMoreInfo_Click(object sender, EventArgs e)
        {
            string help = "A Login System is currently in development.  Check back later!";
            MessageBox.Show(help, sorry);
        }
    }
}
