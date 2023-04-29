using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace FlightReservationSys
{
    public partial class CrystalReport : Form
    {
        CrystalReport3 cr;
        public CrystalReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           cr = new CrystalReport3();
           foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues )
             comboBox1.Items.Add(v.Value);
        }

      
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
