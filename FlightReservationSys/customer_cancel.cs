using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightReservationSys
{
    public partial class customer_cancel : Form
    {
        string ordb = "Data source=xe;User Id=hr;Password=hr;";
        OracleConnection conn;
        int currentCustomerId = 1;
        public customer_cancel()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        static List<Tuple<int,string>> databasedata = new List<Tuple<int, string>>();

        // this function will show/load for the user his/her booked-flights in a combobox as flight id
        // he can select one of the shown flights then the form will have some details about the flight
        // then the user will determine wheather to cancel it or not
        private void customer_cancel_Load(object sender, EventArgs e)
        {
            Query_form_data_from_DB(); // put instead of 1 current customerID
        }
        void Query_form_data_from_DB()
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT FLIGHT_ID,CARD_NUM FROM BOOKED_FLIGHTS WHERE CUSTOMER_ID = :customerId";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("customerId", currentCustomerId);
            OracleDataReader dr = cmd.ExecuteReader();
            int flightId;
            string cardNum;
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());  // flightId is shown in combobox
                flightId = int.Parse(dr[0].ToString());
                cardNum = dr[1].ToString();
                databasedata.Add(new Tuple<int, string>(flightId, cardNum));
            }
            dr.Close();
        }
        void show_flight_details(List<object> flightData)
        {
            // flight details [0:source,1:destination,2:price,3:flightDate,4:cardNumUsed,5:companyName]  order does matter
            if (flightData.Count != 6)
            {
                throw new Exception("flight details list in show_flight_details function has a problem with its count");
                // or simply return from the function
            }
            // show flight details
            sourceTB.Text = flightData[0].ToString();
            destinationTB.Text = flightData[1].ToString();
            priceTB.Text = flightData[2].ToString();
            dateTimeTB.Text = flightData[3].ToString();
            companyNameTB.Text = flightData[4].ToString();
            cardNumTB.Text = flightData[5].ToString();
        }
        List<object> get_flight_data(int currentComboSeletedIdx)
        {
            // add 6 element to flight_data list        
            int flightId = databasedata[currentComboSeletedIdx].Item1;  // or combobox.SelectedItem
            List<object> flight_data = Query_flight_data_from_DB(flightId);
            flight_data.Add(databasedata[currentComboSeletedIdx].Item2);    // adding card num
            return flight_data;
        }

        List<object> Query_flight_data_from_DB(int flightId)
        {
            // thiis function returns list[0:source,1:destination,2:price,3:flightDate,4:companyName]
            // Query flight data form DB using flight id and return it 
            // SELECT * FROM FLIGHT_INFO WHERE FLIGHT_ID =: flightId => using Parameterized Query 
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM FLIGHT_INFO WHERE FLIGHT_ID =: flightId";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("flightId", flightId);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            List<object> flightDetails = new List<object>();
            flightDetails.Add(dr[2]);   //source
            flightDetails.Add(dr[3]);   //destination
            flightDetails.Add(dr[4]);   //price
            flightDetails.Add(dr[6]);   //flightDate

            int adminId = int.Parse(dr[1].ToString());

            flightDetails.Add(get_company_name(adminId));//companyName

            dr.Close();
            return flightDetails;
        }
        string get_company_name(int adminId)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COMPANY_NAME FROM ADMIN_TABLE WHERE ADMIN_ID =: adminId";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("adminId", adminId);

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            string companyName = dr[0].ToString();

            dr.Close();
            return companyName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentComboSeletedIdx = comboBox1.SelectedIndex;
            var flightData = get_flight_data( currentComboSeletedIdx);
            show_flight_details(flightData);
        }

        private void cancel_flight(object sender, EventArgs e)
        {
            // if cancelled button clicked raise new alert to confirm the cancellation
            // if cancellation were confirmed then remove the data from the data base
            if(comboBox1.SelectedIndex == -1)
            {
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to delete this flight ?","Confirm Delete!",MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                delete_booked_flight(databasedata[0].Item1, currentCustomerId);
            }
        }
        void delete_booked_flight(int flightId, int customerId)
        {
            // delete flight from bookedFlights query using flightid and customer id = (primary key)
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE FROM BOOKED_FLIGHTS WHERE FLIGHT_ID =: flightId AND CUSTOMER_ID =: customerId";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("flightId", flightId);
            cmd.Parameters.Add("customerId", customerId);
            cmd.ExecuteReader();        // delete query
            clear_cancel_form();
        }

        void clear_cancel_form()
        {
            comboBox1.Items.Remove(comboBox1.Items[0]);
            sourceTB.Text = string.Empty;
            destinationTB.Text = string.Empty;
            cardNumTB.Text = string.Empty;
            dateTimeTB.Text = string.Empty;
            priceTB.Text = string.Empty;
            companyNameTB.Text = string.Empty;
        }
        private void customer_cancel_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

    }
}
