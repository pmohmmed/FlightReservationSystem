using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace FlightReservationSys
{
    public partial class main_form : Form
    {
        public static main_form main_f;

        public main_form()
        {
            InitializeComponent();
            
        }

        private void main_form_id_Load(object sender, EventArgs e)
        {
            main_f = this;
           
         
        }

        private void connected_button_id_Click(object sender, EventArgs e)
        {
            connected_login_form login_form = new connected_login_form();
            login_form.ShowDialog();
            
        }
    }
}
