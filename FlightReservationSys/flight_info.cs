using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlightReservationSys
{
    public partial class flight_info : Form
    {
        static OracleDataAdapter adapter = null;
        static DataSet ds = null;
        string ordb = "Data source=xe;User Id=hr;Password=hr;";
        OracleConnection conn;
        static int adminID = 0;
        public flight_info()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void flight_info_Load(object sender, EventArgs e)
        {

        }

        void disconnected_mode(int adminID)

        {
            string constr = "Data source=xe;User Id=hr;Password=hr;";
            string cmdstr = "SELECT * FROM FLIGHT_INFO WHERE ADMIN_ID = :adminID";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("adminID", adminID);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            // dataGridView1.Columns["FLIGHT_ID"].DefaultCellStyle.NullValue = getNewFlightID().ToString();
            // dataGridView1.Columns["FLIGHT_ID"].DefaultCellStyle.NullValue = getNewFlightID().ToString();
            dataGridView1.Columns["ADMIN_ID"].ReadOnly = true;
            dataGridView1.Columns["FLIGHT_ID"].ReadOnly = true;

        }
         
        int getNewFlightID()
        {
            int flightId = 0;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(*) FROM FLIGHT_INFO";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                flightId = int.Parse(dr[0].ToString()) + 1;
            }

            return flightId;
        }

        int validAdminDate()
        {
            // validate admin user name & password
            if(adminUserName_TB.Text.Length == 0 || password_TB.Text.Length == 0)
                return -1;
            return adminID = query_admin_by_username_password(adminUserName_TB.Text, password_TB.Text);
        }
        int query_admin_by_username_password(string username,string password)
        {
            // returns admin id if exits
            // return -1 otherwise
            int adminID = -1;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT ADMIN_ID FROM ADMIN_TABLE WHERE USERNAME = :username AND USER_PASSWORD = :password";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("username", username);
            cmd.Parameters.Add("password", password);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adminID = int.Parse(dr[0].ToString());
            }
            dr.Close();
            return adminID;
        }
        private void save_B_Click(object sender, EventArgs e)
        {
            if (adapter is null || ds is null || ds.Tables.Count == 0)
                return;
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            try
            {
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Update Done");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Update Failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var retAdmin = validAdminDate();
            if(retAdmin == -1)
            {
                MessageBox.Show("Wrong Admin Data");
                dataGridView1.DataSource = null;
                return;
            }
            else
            {
                // disconnected_mode
                disconnected_mode(retAdmin);
            }
        }

        void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv == null)
                return;

            var row = dgv.Rows[e.Row.Index];
            
            if (row.IsNewRow)
            {
                // Set your default values here
                dataGridView1.Columns["ADMIN_ID"].ReadOnly = false;
                dataGridView1.Columns["FLIGHT_ID"].ReadOnly = false;
                row.Cells["ADMIN_ID"].Value = adminID;
                row.Cells["FLIGHT_ID"].Value = getNewFlightID().ToString();
                dataGridView1.Columns["ADMIN_ID"].ReadOnly = true;
                dataGridView1.Columns["FLIGHT_ID"].ReadOnly = true;
                // Force the DGV to add the new row by marking it dirty
                dgv.NotifyCurrentCellDirty(true);
            }
        }
    }
}
