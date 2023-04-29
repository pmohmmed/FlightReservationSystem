using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace FlightReservationSys
{
    public partial class admin_form : Form
    {
        long admin_id;
        string ordb = "Data Source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public admin_form(long Id)
        {
            admin_id = Id;
            InitializeComponent();
        }

        private void admin_form_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region variables
            int correct_counter = 4;
            String flight_source = textBox1.Text;
            String flight_dest = textBox2.Text;
            String price_string = textBox3.Text;
            String capacity = textBox4.Text;
            DateTime data_time = dateTimePicker2.Value;
            OracleDate oracle_date = new OracleDate(data_time.Year, data_time.Month, data_time.Day, data_time.Hour, data_time.Minute, data_time.Second);
            int tmp_flight_id = 1;
           // int admin_id = 1;
            int num1; // use it to check if capacity is all num  or not 
            float num2; //use it to check if price is all float  or not 
            textBox7.Text = "";
            #endregion variables

            #region checking_The_Input
            if (flight_source == "" || Regex.IsMatch(flight_source, @"\d"))
            {
                textBox7.Text += " Fill Flight Source " + Environment.NewLine;
                correct_counter--;
            }
            if (flight_dest == "" || Regex.IsMatch(flight_dest, @"\d"))
            {
                textBox7.Text += " Fill Flight Destination " + Environment.NewLine;
                correct_counter--;
            }
            if (price_string == "" || !float.TryParse(price_string, out num2))
            {
                textBox7.Text += " Fill Flight Price " + Environment.NewLine;
                correct_counter--;
            }
            if (capacity == "" || !int.TryParse(capacity, out num1))
            {
                textBox7.Text += " Fill Flight Capacity " + Environment.NewLine;
                correct_counter--;
            }

            #endregion checking_The_Input

            #region dealing_With_Data_Base
            if (correct_counter == 4)
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Flight_ID FROM Flight_Info ORDER BY Flight_ID DESC";
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tmp_flight_id += Convert.ToInt32(dr[0]);
                    break;
                }

                dr.Close();
               // textBox7.Text += Convert.ToString(admin_id) + Environment.NewLine;
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Flight_Info values(:id_flight,:id_admin,:source,:dest,:price,:capacity,:datatimee)";
                cmd.Parameters.Add("id_flight", tmp_flight_id);
                cmd.Parameters.Add("id_admin", admin_id);           //admin id need to be completed 
                cmd.Parameters.Add("source", flight_source);
                cmd.Parameters.Add("dest", flight_dest);
                cmd.Parameters.Add("price", float.Parse(price_string));
                cmd.Parameters.Add("capacity", Convert.ToInt32(capacity));
                cmd.Parameters.Add("datatimee", oracle_date);
                cmd.CommandType = CommandType.Text;

                //  textBox7.Text += data_time + Environment.NewLine;
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    textBox7.Text += " Flight Inserted Successfully  (: " + Environment.NewLine;
                }
                else textBox7.Text += " There is a problem ): " + Environment.NewLine;
            }

            #endregion dealing_With_Data_Base
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
