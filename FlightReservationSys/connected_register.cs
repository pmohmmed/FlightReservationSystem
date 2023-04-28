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

                        //sql_cmd.CommandText = "select admin_id from admin_table where user_password =:pass and username = :username";
                        MessageBox.Show("insert admin reconrd");

                        //int id = 233233;
                        //// retrive id
                        //sql_cmd.CommandText = "select * from admin_table where username=:user";
                        //sql_cmd.Parameters.Add("user", name);
                        //OracleDataReader r = sql_cmd.ExecuteReader();
                        //if (r.Read())
                        //{
                        //    MessageBox.Show("exist");

                        //}
                        //id = sql_cmd.ExecuteNonQuery();
                        //if (id != -1)
                        //{
                        //    MessageBox.Show("exist");
                        //}
                        //else
                        //    MessageBox.Show("not exist");
                        //sql_cmd.CommandText = "insert into admin_table (username,admin_id, company_name, , user_password) values(:username,:admin_id, :company,  :pass) ";
                        //sql_cmd.Parameters.Add("admin_id",id);
                        //sql_cmd.Parameters.Add("company", company);

                        //sql_cmd.Parameters.Add("username", name);
                        //sql_cmd.Parameters.Add("pass", pass);


                        //sql_cmd.ExecuteNonQuery();
                        
                        username_textbox_id.Text = password_textbox_id.Text = company_textbox_id.Text ="";

                    }
                    else
                    
                        MessageBox.Show("complete all fields");
                    

                }
                else // customer
                {
                    MessageBox.Show("insert customer info");

                    // store in customer table

                    // give a message

                    username_textbox_id.Text = password_textbox_id.Text = "";


                }




            }
            else
                MessageBox.Show("complete all fields");

        }
    }
}
