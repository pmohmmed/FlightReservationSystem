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
        public static connected_login_form login_f;
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

 
        private void connected_form_load(object sender, EventArgs e)
        {
            login_f = this;
            conn = new OracleConnection(orcl);
            conn.Open();

            password_textbox_id.PasswordChar = '*';
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
                        //MessageBox.Show("admin id: " + admin_id.ToString());

                        d.Close();

                        admin_form admin_fo = new admin_form(admin_id);
                        admin_fo.Show();
                        //main_form.main_f.Hide();
                        main_form.main_f.WindowState = FormWindowState.Minimized;

                        this.Dispose();
                       
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
                        //MessageBox.Show("customer id: " + customer_id.ToString());

                        d.Close();
                        customer_form customer_fo = new customer_form(customer_id);
                        customer_fo.Show();
                        //main_form.main_f.Hide();
                        main_form.main_f.WindowState = FormWindowState.Minimized;
                        this.Dispose();

                  
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
            connected_register_form register_form = new connected_register_form();
            login_f.Dispose();

            register_form.ShowDialog();

        }

        private void admin_radio_id_CheckedChanged(object sender, EventArgs e)
        {
            account = admin_radio_id.Text;
        }

        private void customer_radio_id_CheckedChanged(object sender, EventArgs e)
        {
            account = customer_radio_id.Text;

        }

    

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void connected_form_closing(object sender, FormClosingEventArgs e)
        {
           
            conn.Dispose();
        }

    }
}
