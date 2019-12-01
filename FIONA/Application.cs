using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIONA
{
    public partial class Application : Form

    {
        #region variables & constructor(s)

        FtpServer test_server;
        private bool _connectionStarted;
        private string sorry = "Sorry about that...";
        private string notice = "Just so you know...";
        DatabaseComms db_comm = new DatabaseComms();

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

        #endregion

        #region panel entry

        /// <summary>
        /// Alerts the user that they are bypassing a future login system when they pass through
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //string help = "A Login System is currently in development.  You are being forwarded in as a generic user.";
            //MessageBox.Show(help, notice);

            try
            {
                var addr = new System.Net.Mail.MailAddress(textBoxLoginEmail.Text);
                if (addr.Address == textBoxLoginEmail.Text)
                {
                    if (db_comm.login(textBoxLoginEmail.Text, textBoxLoginPassword.Text))
                    {
                        panelMainMenu.BringToFront();
                    }
                }
            }
            catch
            {
                Console.WriteLine("login attempted with invalid email");
                string help = "Sorry, not a proper email format.  Please try again with an email of type a@b.com";
                MessageBox.Show(help, sorry);
            }
        }

        /// <summary>
        /// this function should handle login events, but presently just passes user through to the next panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if (textBoxSignupConfirm.Text.CompareTo(textBoxSignupPassword.Text) == 0)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(textBoxLoginEmail.Text);
                    if (addr.Address == textBoxLoginEmail.Text)
                    {
                        if (db_comm.signup(textBoxSignupEmail.Text, textBoxSignupPassword.Text))
                        {
                            panelMainMenu.BringToFront();
                        }
                        else
                        {
                            Console.WriteLine("signup attempt failed");
                            string help = "Sorry, something went wrong with the sign up process.  Please try again.";
                            MessageBox.Show(help, sorry);
                        }
                    }
                    else
                    {
                        Console.WriteLine("signup attempt failed due to mismatched passwords");
                        string help = "Sorry, your passwords don't match.  Please try again.";
                        MessageBox.Show(help, sorry);
                    }
                }
                catch
                {
                    Console.WriteLine("signup attempted with invalid email");
                    string help = "Sorry, not a proper email format.  Please try again with an email of type a@b.com";
                    MessageBox.Show(help, sorry);
                }
            }
        }

        #endregion

        #region panel main menu

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (_connectionStarted)
            {
                test_server.Stop();
            }
            textBoxLoginEmail.Text = "";
            textBoxLoginPassword.Text = "";
            textBoxSignupEmail.Text = "";
            textBoxSignupPassword.Text = "";
            textBoxSignupConfirm.Text = "";
            sessionVariables.userEmail = null;
            _connectionStarted = false;
            panelEntry.BringToFront();
        }

        /// <summary>
        /// Alerts the user that this feature is not currently available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnectMain_Click(object sender, EventArgs e)
        {
            //string help = "Sorry, this feature still in development.  Check back soon!";
            //MessageBox.Show(help, sorry);
            //panelMainMenu.BringToFront();
            // below is what this button is supposed to do when feature built
            panelConnect.BringToFront();
        }

        /// <summary>
        /// brings share panel to front
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShareMain_Click(object sender, EventArgs e)
        {
            db_comm.reset_ip();
            panelShare.BringToFront();
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

        #endregion

        #region panel share

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
        private void go_online()
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

        /// <summary>
        /// 
        /// </summary>
        private void go_offline()
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
                string folderAlreadySelectedMessage = "Sorry, currently only one folder can be shared.  Would you like to change your current download folder?";
                DialogResult dialogResult = MessageBox.Show(folderAlreadySelectedMessage, sorry, MessageBoxButtons.YesNo);
                // if user wishes to override existing share, sets new share folder
                if (dialogResult == DialogResult.Yes)
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
                        go_online();
                    }
                }
            }
            // if server already started, clicking the button shuts down the server
            else
            {
                go_offline();
            }
        }

        #endregion

        #region panel connect

        private void ButtonDownloadPicker_Click(object sender, EventArgs e)
        {
            // first checks if a folder is already set
            if (Properties.Settings.Default.dlAppVar != "null")
            {
                string folderAlreadySelectedMessage = "Sorry, currently only one folder can be downloaded to.  Would you like to change your current share folder?";
                DialogResult dialogResult = MessageBox.Show(folderAlreadySelectedMessage, sorry, MessageBoxButtons.YesNo);
                // if user wishes to override existing share, sets new share folder
                if (dialogResult == DialogResult.Yes)
                {
                    FolderBrowserDialog rootPicker = new FolderBrowserDialog();
                    DialogResult result = rootPicker.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(rootPicker.SelectedPath))
                    {
                        Properties.Settings.Default.dlAppVar = rootPicker.SelectedPath;
                        labelDownloadPath.Text = Properties.Settings.Default.dlAppVar;
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
                    Properties.Settings.Default.dlAppVar = rootPicker.SelectedPath;
                    labelDownloadPath.Text = Properties.Settings.Default.dlAppVar;
                }
            }
        }
                private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            ftpClient client = new ftpClient(@"localhost:21", "asdf", "");
            //client.directoryListSimple(@"C:\fiona");

            Task<string[]> simpleDirectoryListing = client.directoryListDetailed(@"C:\fiona");
            for (int i = 0; i < simpleDirectoryListing.Result.Length; i++)
            {
                Console.WriteLine(simpleDirectoryListing.Result[i]);
            }
        }

        private void ButtonDownloadShow_Click(object sender, EventArgs e)
        {
            ftpClient client = new ftpClient(@"localhost:21", "asdf", "");
            client.download("Transcript.pdf", @"C:\fiona\NewFolder\Transcript.pdf");
        }
        private void temp_getListing(object sender, EventArgs e)
        {
            ftpClient client = new ftpClient(@"localhost:21", "asdf", "");
            //client.directoryListSimple(@"C:\fiona");

            Task<string[]> simpleDirectoryListing = client.directoryListDetailed(@"C:\fiona");
            for (int i = 0; i < simpleDirectoryListing.Result.Length; i++)
            {
                Console.WriteLine(simpleDirectoryListing.Result[i]);
            }
        }

        #endregion
    }
}
