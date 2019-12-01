using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIONA
{
    class DatabaseComms
    {

        private string sorry = "Whoops...";
        private string yay = "It worked!";


        public bool login(string email, string password)
        {
            // opening sql connection to check if login email exists
            SqlConnection conn = new SqlConnection(@"Data Source=RWHITE83-LAPTOP;Initial Catalog=fiona-db;Integrated Security=True");
            conn.Open();
            Console.WriteLine("Login connection state: " + conn.State);

            string email_attempt = email;
            string password_attempt = email;
            string email_retrieved = "email not found";
            string password_retrieved = "password not found";

            int row_count = 0;
            // try catch here for safety
            using (SqlCommand command = new SqlCommand("SELECT * FROM fionaUsers WHERE userEmail = '" + email_attempt + "'", conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email_retrieved = reader.GetString(1);
                        password_retrieved = reader.GetString(2);
                        row_count++;
                    }
                }
            }
            Console.WriteLine("userEmail retrieved from db: " + email_retrieved);

            if (row_count == 0)
            {
                Console.WriteLine("user not found");
                string help = "This email not registered, please sign up!";
                MessageBox.Show(help, sorry);
                return false;
            }
            else if (row_count == 1)
            {
                if (password_attempt.CompareTo(password_retrieved) != 0)
                {
                    Console.WriteLine("compared successfully");
                    sessionVariables.userEmail = email_retrieved;
                    return true;
                }
                else
                {
                    // this needs to be a proper pop out
                    Console.WriteLine("sorry, passwords do not match");
                    string help = "Sorry, your passwords don't match.  Please try again!";
                    MessageBox.Show(help, sorry);
                    return false;
                }
            }
            else
            {
                // this needs to be a proper pop out
                Console.WriteLine("something went wrong.  multiple users with this email found. sorry, this should never happen.");
                string help = "Multiple aaccounts with this email found.  Sorry, this should never happen!  "
                    + "Please contact administrators and/or sign up with new email account.";
                MessageBox.Show(help, sorry);
                return false;
            }
        }

        public bool signup(string email, string password)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=RWHITE83-LAPTOP;Initial Catalog=fiona-db;Integrated Security=True");
            conn.Open();
            Console.WriteLine("Signup connection state: " + conn.State);

            string email_attempt = email;
            string password_attempt = email;
            bool email_okay = true;

            // put try catches here for safety
            Console.WriteLine("email attempt: " + email_attempt);
            using (SqlCommand command = new SqlCommand("SELECT * FROM fionaUsers WHERE userEmail = '" + email_attempt + "'", conn))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        email_okay = false;
                    }
                }
            }

            if (!email_okay)
            {
                // proper pop up here
                Console.WriteLine("sorry, this email already used, please login or try with a different email.");
                string help = "Sorry, this email already used.  Please login or try with a different email.";
                MessageBox.Show(help, sorry);
                return false;
            }
            else
            {
                // i know i need to hash the password, this is early going
                string hostName = Dns.GetHostName();
                string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

                Console.WriteLine(myIP);

                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlDataAdapter sda = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand("INSERT INTO fionaUsers (userEmail, userPassword, userIP) VALUES ('"
                                + email + "', '" + password + "', '" + myIP + "')", conn);
                adapter.InsertCommand.ExecuteNonQuery();
                Console.WriteLine(email + " successfully signed up in theory");
                string help = "Sign up successful!";
                MessageBox.Show(help, yay);
            }
            return true;
        }

        public void reset_ip()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=RWHITE83-LAPTOP;Initial Catalog=fiona-db;Integrated Security=True");
            conn.Open();
            Console.WriteLine("reset ip connection state: " + conn.State);

            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataAdapter sda = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand("UPDATE fionaUsers SET userIP = '" + myIP 
                + "' WHERE userEmail = '" + sessionVariables.userEmail + "'", conn);
            adapter.InsertCommand.ExecuteNonQuery();

        }
    }
}
