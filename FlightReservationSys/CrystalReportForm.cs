﻿using System;
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
    public partial class CrystalReportForm : Form
    {
        CrystalReport1 cr;
        OrdinalReport cr2;
        CrystalReport2 cr3;
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            cr2 = new OrdinalReport();
            cr3 = new CrystalReport2();
            foreach(ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues )
            {
                user_name_category_cmb_id.Items.Add(v.Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generate_report_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, user_name_category_cmb_id.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void ordinal_report_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr3;
        }
    }
}
