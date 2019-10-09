using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIONA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMainMenu.BringToFront();
        }

        private void buttonConnectMain_Click(object sender, EventArgs e)
        {
            panelConnect.BringToFront();
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

            SqlConnection conn = new SqlConnection(@"Data Source=fiona.database.windows.net;Initial Catalog=FIONA_db;User ID=team_fiona;Password=#Wubbalubbadubdub;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            conn.Open();

            Console.WriteLine(conn.State);

            // i know i need to hash the password, this is early going
            string new_username = username_txtbx.Text;
            string new_password = password_txtbx.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            //SqlDataAdapter sda = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand("INSERT INTO users (username, password) VALUES ('" +  new_username + "', '" + new_password + "')", conn);
            adapter.InsertCommand.ExecuteNonQuery();
        }
    }
}
