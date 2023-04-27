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
    public partial class main_form_id : Form
    {
        string ordb = "Data Source=ORCL; User Id=scott; Password=tiger;";
        OracleConnection conn;
        public main_form_id()
        {
            InitializeComponent();
        }

        private void main_form_id_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            //HELP HELP HELP HELP
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select actorId from actors";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox_id.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void main_form_closing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
