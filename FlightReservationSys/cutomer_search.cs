using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightReservationSys
{
    //EDIT EDIT

    public partial class cutomer_search : Form
    {
        List<int> currentListBoxFlightId = new List<int>();
        List<int> currentListBoxCapacity = new List<int>();
        int clickedFlightId = -1,
            currentClickedFlightCapacity = -1,
            indexOfClickedItem = -1;
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
            textBox4.Visible = false;
            textBox7.Visible = false;
            listBox1.Items.Clear();
            currentListBoxFlightId.Clear();
            currentListBoxCapacity.Clear();
            label9.Visible= false;
            label10.Visible=false;
            clickedFlightId = -1;
            currentClickedFlightCapacity = -1;
            indexOfClickedItem = -1;
        }
        private void cutomer_search_Load_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private bool checkCustomerBalance(string cardNum, int pin)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select balance from bank_info where card_num =:card_num AND PIN =:pin";
            cmd.Parameters.Add("card_num", cardNum);
            cmd.Parameters.Add("pin", pin.ToString());
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
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clickedFlightId != -1)
            {
                textBox4.Visible = true;
                textBox7.Visible = true;
                while (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox7.Text))
                {

                }

                bool reservationStatus = makeReservation(clickedFlightId, currentClickedFlightCapacity);
                if (reservationStatus)
                {
                    label9.Visible = true;
                    if (currentClickedFlightCapacity == 1)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                        listBox1.Refresh();
                    }
                    listBox1.Refresh();
                }
                else
                    label10.Visible = true;
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
