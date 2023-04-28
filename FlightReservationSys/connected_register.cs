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
    public partial class connected_register_form : Form
    {
        string name = "";
        string pass = "";
        string account = ""; // admin or customer
        string company = "";
        string orcl = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        OracleCommand sql_cmd;


        public connected_register_form()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private int get_id(OracleConnection conn, string table, string column)
        {
            int id = 1;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select " + column + " from " + table + " order by " + column + " desc";
            OracleDataReader r = cmd.ExecuteReader();
          
          
            while(r.Read())
            {
                
                id = Int32.Parse(r[0].ToString()) +1;
                break;
                
            }
            r.Close();
           return id;
            
            
        }

        private void connected_register_form_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(orcl);
            conn.Open();
            password_textbox_id.PasswordChar = '*';
        }

        private void admin_radio_id_CheckedChanged(object sender, EventArgs e)
        {
            account = admin_radio_id.Text;
            company_label_id.Visible = true;
            company_textbox_id.Visible = true;

        }

        private void customer_radio_id_CheckedChanged(object sender, EventArgs e)
        {
            account = customer_radio_id.Text;

            company_label_id.Visible = false;
            company_textbox_id.Visible = false;
        }

        private void register_button_id_Click(object sender, EventArgs e)
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
                    company = company_textbox_id.Text.Trim();
                    if(company != "")
                    {


                        sql_cmd.CommandText = "insert into admin_table (admin_id, company_name,username , user_password) values(:admin_id, :company, :username, :pass) ";

                        sql_cmd.Parameters.Add("admin_id", get_id(conn, "admin_table", "admin_id"));
                        sql_cmd.Parameters.Add("company", company);
                        sql_cmd.Parameters.Add("username", name);
                        sql_cmd.Parameters.Add("pass", pass);


                        sql_cmd.ExecuteNonQuery();
                        MessageBox.Show("SUCCESSFUL PROCESS");

                        username_textbox_id.Text = password_textbox_id.Text = company_textbox_id.Text ="";

                    }
                    else
                    
                        MessageBox.Show("complete all fields");
                    

                }
                else // customer
                {

                    sql_cmd.CommandText = "insert into CUSTOMER (CUSTOMER_ID, username , user_password) values(:user_id,  :username, :pass) ";

                    sql_cmd.Parameters.Add("user_id", get_id(conn, "customer", "customer_id"));
                    sql_cmd.Parameters.Add("username", name);
                    sql_cmd.Parameters.Add("pass", pass);


                    sql_cmd.ExecuteNonQuery();
                    MessageBox.Show("SUCCESSFUL PROCESS");


                    username_textbox_id.Text = password_textbox_id.Text = "";


                }




            }
            else
                MessageBox.Show("complete all fields");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void register_form_closing(object sender, FormClosingEventArgs e)
        {
            
            conn.Dispose();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void login_button_id_Click(object sender, EventArgs e)
        {
            connected_login_form login = new connected_login_form();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
