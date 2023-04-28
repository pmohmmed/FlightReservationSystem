using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace FlightReservationSys
{
    public partial class connected_login_form : Form
    {
        string name ="";
        string pass = "";
        string account = ""; // admin or customer
        string orcl = "Data Source = orcl;User Id=scott;Password = tiger;";
        OracleConnection conn;
        OracleCommand sql_cmd;

        public connected_login_form()
        {
            InitializeComponent();
        }

        private void connected_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(orcl);
            conn.Open();
        
            password_textbox_id.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_id_Click(object sender, EventArgs e)
        {
            name = username_textbox_id.Text.Trim();
            pass = password_textbox_id.Text.Trim();

            if (name != "" && pass != "" && account != "")
            {
                // oracle check
                sql_cmd = new OracleCommand();
                sql_cmd.Connection = conn;
                sql_cmd.CommandType = CommandType.Text;
                if (account == admin_radio_id.Text)
                {
                    // retrive id
                    sql_cmd.CommandText = "select admin_id from admin_table where user_password =:pass and username = :username";
                    sql_cmd.Parameters.Add("pass", pass);
                    sql_cmd.Parameters.Add("username", name);
                    long admin_id;
                    OracleDataReader d = sql_cmd.ExecuteReader();
                    if (d.Read())
                    {
                        admin_id = Int64.Parse(d[0].ToString());
                        MessageBox.Show("admin id: " + admin_id.ToString());

                        //d.Close();
                        //// open admin form
                    }
                    else
                    {
                        MessageBox.Show("Wrong password or username");
                    }
                    d.Close();

                }
                else // customer
                {
                    // retrive id
                    sql_cmd.CommandText = "select customer_id from customer where user_password =:pass and username = :username";
                    sql_cmd.Parameters.Add("pass", pass);
                    sql_cmd.Parameters.Add("username", name);
                    long customer_id;
                    OracleDataReader d = sql_cmd.ExecuteReader();
                    if (d.Read())
                    {
                        customer_id = Int64.Parse(d[0].ToString());
                        MessageBox.Show("customer id: " + customer_id.ToString());

                        //d.Close();
                        //// open customer form
                    }
                    else
                    {
                        MessageBox.Show("Wrong password or username");
                    }
                    d.Close();
                }

                username_textbox_id.Text = password_textbox_id.Text = "";


            }
            else
                MessageBox.Show("complete all fields");
        }

        private void register_button_id_Click(object sender, EventArgs e)
        {
            // open register form
            MessageBox.Show("go to register form");

        }

        private void admin_radio_id_CheckedChanged(object sender, EventArgs e)
        {
            account = admin_radio_id.Text;
        }

        private void customer_radio_id_CheckedChanged(object sender, EventArgs e)
        {
            account = customer_radio_id.Text;

        }

        private void connection_form_closing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
