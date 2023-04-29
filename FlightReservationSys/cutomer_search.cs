using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FlightReservationSys
{
    //EDIT EDIT

    public partial class cutomer_search : Form
    {
        List<int> currentListBoxFlightId = new List<int>();
        List<int> currentListBoxCapacity = new List<int>();
        List<int> currentListBoxPrice = new List<int>();
        int loggedCustomerId = 2;
        int clickedFlightId = -1,
            currentClickedFlightCapacity = -1,
            indexOfClickedItem = -1,
            currentClickedFlightPrice = -1;
        string ordb = "Data Source=ORCL; User Id=scott; Password=tiger;";
        OracleConnection conn;
        public cutomer_search()
        {
            InitializeComponent();
            resetTheForm();

        }

        // for every search and initialization of the form we need to set some values
        void resetTheForm()
        {
            listBox1.Items.Clear();
            currentListBoxFlightId.Clear();
            currentListBoxCapacity.Clear();
            currentListBoxPrice.Clear();
            label9.Visible= false;
            label10.Visible=false;
            clickedFlightId = -1;
            currentClickedFlightCapacity = -1;
            indexOfClickedItem = -1;
            currentClickedFlightPrice = -1;
        }
        private void cutomer_search_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void insertBookingHistory(int customerId, int flightId, string cardNum)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into booked_flights values(:flightId , :customerId , :cardNum)";
            cmd.Parameters.Add("flightId", flightId);
            cmd.Parameters.Add("customerId", customerId.ToString());
            cmd.Parameters.Add("cardNum", cardNum);
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cmd.Dispose();
            }
            // Clean up resources
            cmd.Dispose();
        }
        private int isBookedBefore(int flightId, int customerId)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "get_booked_tickets_count";
            cmd.Parameters.Add("customer_id", OracleDbType.Int32).Value = customerId;
            cmd.Parameters.Add("flight_id", OracleDbType.Int32).Value = flightId;

            cmd.Parameters.Add("count", OracleDbType.Int32, ParameterDirection.Output);


            // Retrieve the output parameter value
            int count = -1;

            try
            {
                cmd.ExecuteNonQuery();
                var c = cmd.Parameters["count"].Value;
                count = Convert.ToInt32(c.ToString());
            }
            catch (DbException ex)
            {
                cmd.Dispose();
            }
            // Clean up resources
            cmd.Dispose();

            return count;
        }
        private int checkCustomerBalance(int customerId, string cardNum, int pin, float flightPrice)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_balance";
            cmd.Parameters.Add("card_num", OracleDbType.Varchar2).Value = cardNum;
            cmd.Parameters.Add("PIN", OracleDbType.Int32).Value = pin;
            cmd.Parameters.Add("balance", OracleDbType.Int32, ParameterDirection.Output);

            int balance = -1;

            try
            {
                cmd.ExecuteNonQuery();
                if (cmd.Parameters["balance"].Value != null)
                    balance = Convert.ToInt32(cmd.Parameters["balance"].Value.ToString());
                else
                    return 0;
            }
            catch (Exception ex)
            {
                var c = cmd.Parameters["balance"].Value;
                var cd = cmd.Parameters["card_num"].Value;
                var ccd = cmd.Parameters["PIN"].Value;
                cmd.Dispose();
            }
            // Clean up resources
            cmd.Dispose();

            return balance;
        }
        private void updateCustomerBalance(int customerId, float newBalanceToSet)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update bank_info set balance = :newBalance where customer_id = :customerId";
            var newBalance = 
            cmd.Parameters.Add("newBalance", newBalanceToSet);
            cmd.Parameters.Add("customerId", customerId.ToString());
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                cmd.Dispose();
            }
            // Clean up resources
            cmd.Dispose();
        }
        private bool makeReservation(int flightId, int currentCapacity)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string newCapacity = (currentCapacity - 1).ToString();
            // Set the SQL statement with bind variables
            cmd.CommandText = "update flight_info set capacity = :cap where flight_id = :f_id";
            cmd.Parameters.Add("cap", newCapacity);
            cmd.Parameters.Add("f_id", flightId.ToString());
            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (DbException ex)
            {
                cmd.Dispose();
                return false;
            }
            // Clean up resources
            cmd.Dispose();
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetTheForm();
            bool useJoinedStatementFlag = false;
            StringBuilder stringBuilder = new StringBuilder(
                "select flight_src,flight_dest,price,datetime,flight_id, capacity from flight_info where ");
            StringBuilder joinStatment = new StringBuilder(
                "select admin_id from admin_table where  ");

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                stringBuilder.Append($"flight_src = '{textBox1.Text}' AND ");
            }
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                stringBuilder.Append($"flight_dest = '{textBox2.Text}' AND ");
            }
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                stringBuilder.Append($"price <= '{textBox3.Text}' AND ");
            }
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                stringBuilder.Append($"datetime = '{textBox5.Text}' AND ");
            }
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                useJoinedStatementFlag = true;
                joinStatment.Append($"company_name = '{textBox6.Text}'");
                stringBuilder.Append($"admin_id = ({joinStatment.ToString()})");
            }

            if (stringBuilder.ToString().EndsWith("AND "))
            {
                stringBuilder.Append($"capacity > 0");
            }
            else if (!useJoinedStatementFlag)
            {
                stringBuilder.Append($"capacity > 0");
            }
            else
            {
                stringBuilder.Append($" AND capacity > 0");
            }
            stringBuilder.Append($"order by price");
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = stringBuilder.ToString();
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                StringBuilder answer = new StringBuilder();
                answer.Append($"'{dr[0]}'  {dr[1]},  '{dr[2]}', {dr[3]}");
                currentListBoxFlightId.Add(int.Parse(dr[4].ToString()));
                currentListBoxCapacity.Add(int.Parse(dr[5].ToString()));
                currentListBoxPrice.Add(int.Parse(dr[2].ToString()));
                listBox1.Items.Add(answer);
            }
            cmd.Dispose();
            dr.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            indexOfClickedItem = listBox1.IndexFromPoint(e.Location);

            // If an item was clicked, set it in the TextBox
            if (indexOfClickedItem != ListBox.NoMatches)
            {
                clickedFlightId = currentListBoxFlightId[indexOfClickedItem];
                currentClickedFlightCapacity = currentListBoxCapacity[indexOfClickedItem];
                currentClickedFlightPrice    = currentListBoxPrice[indexOfClickedItem];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Thread.Sleep(1000);
            if (clickedFlightId != -1 && !string.IsNullOrEmpty(textBox4.Text) && 
                !string.IsNullOrEmpty(textBox7.Text))
            {
                int isBookedStatus = isBookedBefore(clickedFlightId, loggedCustomerId);

                int customerBalance = checkCustomerBalance(loggedCustomerId, textBox4.Text,
                    int.Parse(textBox7.Text), currentClickedFlightPrice);

                bool reservationStatus = false;

                if (isBookedStatus == 0 &&  customerBalance>= currentClickedFlightPrice)
                {
                    reservationStatus = makeReservation(clickedFlightId, currentClickedFlightCapacity);
                    updateCustomerBalance(loggedCustomerId, customerBalance - currentClickedFlightPrice);
                }
                if (reservationStatus)
                {
                    insertBookingHistory(loggedCustomerId, clickedFlightId, textBox4.Text);
                    // remove the cursor if a flight is booked to prepare new search or book operation
                    label9.Visible = true;
                    if (currentClickedFlightCapacity == 1)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        //listBox1.Refresh();
                    }
                    listBox1.SelectedIndex = -1;
                    //listBox1.Refresh();
                }
                else
                    label10.Visible = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void cutomer_search_FormClosing(object sender, FormClosingEventArgs e)
        {
            resetTheForm();
            conn.Dispose();
        }

        private void cutomer_search_FormClosed(object sender, FormClosedEventArgs e)
        {
            // return to the main form
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
