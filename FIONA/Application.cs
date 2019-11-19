using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIONA
{
    public partial class Application : Form

    {
        FtpServer test_server;
        private bool _connectionStarted;
        private string sorry = "Sorry about that...";
        private string notice = "Just so you know...";

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

        public Application()
        {
            InitializeComponent();
            _connectionStarted = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string help = "A Login System is currently in development.  You are being forwarded in as a generic user.";
            MessageBox.Show(help, notice);
            panelMainMenu.BringToFront();
        }

        private void buttonConnectMain_Click(object sender, EventArgs e)
        {
            string help = "Sorry, this feature still in development.Check back soon!";
            MessageBox.Show(help, sorry);
            panelMainMenu.BringToFront();
            //panelConnect.BringToFront();
        }

        private void buttonShareMain_Click(object sender, EventArgs e)
        {
            panelShare.BringToFront();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelMainMenu.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelMainMenu.BringToFront();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            panelEntry.BringToFront();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string help = "A Login System is currently in development.  You are being forwarded in as a generic user.";
            MessageBox.Show(help, notice);
            panelMainMenu.BringToFront();

            //////////////////////////////////////////////////////////////////////////////
            // depracated until we develop more core functionality
            // I originally conceived this in Azure, but large costs forced me out
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


        private void ButtonShareStartStop_Click(object sender, EventArgs e)
        {
            if (!_connectionStarted)
            {
                if (Properties.Settings.Default.rootAppVar == "null")
                {
                    string help = "Whoops!  Please select a share folder before attempting to start sharing.";
                    MessageBox.Show(help, sorry);
                }
                else
                {
                    Console.WriteLine("starting server");
                    test_server = new FtpServer(this, Properties.Settings.Default.rootAppVar);
                    if (!_connectionStarted)
                    {
                        buttonShareStartStop.ForeColor = Color.OrangeRed;
                        buttonShareStartStop.BackColor = Color.DarkRed;
                        labelStatus.Text = "Server Status: Online";
                        buttonShareStartStop.Text = "Stop Sharing";
                        _connectionStarted = true;
                        test_server.Start();
                    }
                }
            }
            else
            {
                Console.WriteLine("shutting down server");
                test_server.Stop();
                buttonShareStartStop.BackColor = Color.ForestGreen;
                buttonShareStartStop.ForeColor = Color.GreenYellow;
                labelStatus.Text = "Server Status: Offline";
                buttonShareStartStop.Text = "Stop Sharing";
                _connectionStarted = false;
            }
        }

        private void ButtonAddShared_Click(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.rootAppVar != "null")
            {
                string folderAlreadySelectedMessage = "Sorry, currently only one folder can be shared.  Would you like to change your current share folder?";
                DialogResult dialogResult = MessageBox.Show(folderAlreadySelectedMessage, sorry, MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    FolderBrowserDialog rootPicker = new FolderBrowserDialog();
                    DialogResult result = rootPicker.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(rootPicker.SelectedPath))
                    {
                        Properties.Settings.Default.rootAppVar = rootPicker.SelectedPath;
                        Properties.Settings.Default.Save();
                        labelFolderList.Text = Properties.Settings.Default.rootAppVar;
                    }
                }
            }
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

        private void Label1_Click(object sender, EventArgs e)
        {
            string help = "A Login System is currently in development.  Check back later!";
            MessageBox.Show(help, sorry);
        }
    }
}
