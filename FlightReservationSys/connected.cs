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
    public partial class connected_form : Form
    {
        string name ="";
        string pass = "";
        string account = ""; // admin or customer

        public connected_form()
        {
            InitializeComponent();
        }

        private void connected_Load(object sender, EventArgs e)
        {
            password_textbox_id.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_id_Click(object sender, EventArgs e)
        {
            name = username_textbox_id.Text.Trim();
            pass = password_textbox_id.Text.Trim();

            if (name != "" && name !=" " && pass !="" && pass !=" " && account != "")
            {
                // oracle check

                // transorm to admin or customer form



                // temp
                username_textbox_id.Text = password_textbox_id.Text = "";
                MessageBox.Show("hi, " + name + "\nyour password: " + pass);

            }
        }

        private void register_button_id_Click(object sender, EventArgs e)
        {
            name = username_textbox_id.Text.Trim();
            pass = password_textbox_id.Text.Trim();
            if (name != "" && pass != ""  && account !="")
            {
                // oracle insert

                // transorm to admin or customer form based on the radio button

                

                // temp
                username_textbox_id.Text = password_textbox_id.Text = "";
                MessageBox.Show("hi, " + name + "\nyour password: " + pass+"\naccount: "+account);

            }
        }

        private void admin_radio_id_CheckedChanged(object sender, EventArgs e)
        {
            account = admin_radio_id.Text;
        }

        private void customer_radio_id_CheckedChanged(object sender, EventArgs e)
        {
            account = customer_radio_id.Text;

        }
    }
}
