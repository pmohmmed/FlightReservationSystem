using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationSys
{
    public partial class cutomer : Form
    {
        public cutomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form cus = new Form();
            cus.ShowDialog();
        }

        private void cutomer_Load(object sender, EventArgs e)
        {

        }

        private void cancel_button_id_Click(object sender, EventArgs e)
        {

        }
    }
}
