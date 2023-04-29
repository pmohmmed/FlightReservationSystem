namespace FlightReservationSys
{
    partial class connected_login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_button_id = new System.Windows.Forms.Button();
            this.register_button_id = new System.Windows.Forms.Button();
            this.admin_radio_id = new System.Windows.Forms.RadioButton();
            this.customer_radio_id = new System.Windows.Forms.RadioButton();
            this.username_textbox_id = new System.Windows.Forms.TextBox();
            this.password_textbox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button_id
            // 
            this.login_button_id.Location = new System.Drawing.Point(30, 168);
            this.login_button_id.Name = "login_button_id";
            this.login_button_id.Size = new System.Drawing.Size(202, 33);
            this.login_button_id.TabIndex = 0;
            this.login_button_id.Text = "login";
            this.login_button_id.UseVisualStyleBackColor = true;
            this.login_button_id.Click += new System.EventHandler(this.login_button_id_Click);
            // 
            // register_button_id
            // 
            this.register_button_id.Location = new System.Drawing.Point(92, 237);
            this.register_button_id.Name = "register_button_id";
            this.register_button_id.Size = new System.Drawing.Size(77, 33);
            this.register_button_id.TabIndex = 1;
            this.register_button_id.Text = "register";
            this.register_button_id.UseVisualStyleBackColor = true;
            this.register_button_id.Click += new System.EventHandler(this.register_button_id_Click);
            // 
            // admin_radio_id
            // 
            this.admin_radio_id.AutoSize = true;
            this.admin_radio_id.Location = new System.Drawing.Point(30, 135);
            this.admin_radio_id.Name = "admin_radio_id";
            this.admin_radio_id.Size = new System.Drawing.Size(53, 17);
            this.admin_radio_id.TabIndex = 2;
            this.admin_radio_id.TabStop = true;
            this.admin_radio_id.Text = "admin";
            this.admin_radio_id.UseVisualStyleBackColor = true;
            this.admin_radio_id.CheckedChanged += new System.EventHandler(this.admin_radio_id_CheckedChanged);
            // 
            // customer_radio_id
            // 
            this.customer_radio_id.AutoSize = true;
            this.customer_radio_id.Location = new System.Drawing.Point(101, 135);
            this.customer_radio_id.Name = "customer_radio_id";
            this.customer_radio_id.Size = new System.Drawing.Size(68, 17);
            this.customer_radio_id.TabIndex = 3;
            this.customer_radio_id.TabStop = true;
            this.customer_radio_id.Text = "customer";
            this.customer_radio_id.UseVisualStyleBackColor = true;
            this.customer_radio_id.CheckedChanged += new System.EventHandler(this.customer_radio_id_CheckedChanged);
            // 
            // username_textbox_id
            // 
            this.username_textbox_id.Location = new System.Drawing.Point(30, 32);
            this.username_textbox_id.Name = "username_textbox_id";
            this.username_textbox_id.Size = new System.Drawing.Size(202, 20);
            this.username_textbox_id.TabIndex = 4;
            this.username_textbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password_textbox_id
            // 
            this.password_textbox_id.Location = new System.Drawing.Point(30, 96);
            this.password_textbox_id.Name = "password_textbox_id";
            this.password_textbox_id.Size = new System.Drawing.Size(202, 20);
            this.password_textbox_id.TabIndex = 5;
            this.password_textbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "password";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.login_button_id);
            this.groupBox1.Controls.Add(this.register_button_id);
            this.groupBox1.Controls.Add(this.password_textbox_id);
            this.groupBox1.Controls.Add(this.admin_radio_id);
            this.groupBox1.Controls.Add(this.username_textbox_id);
            this.groupBox1.Controls.Add(this.customer_radio_id);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(-13, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 299);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "--- or creat an account ---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // connected_login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(240, 281);
            this.Controls.Add(this.groupBox1);
            this.Name = "connected_login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.connected_form_closing);
            this.Load += new System.EventHandler(this.connected_form_load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button login_button_id;
        private System.Windows.Forms.Button register_button_id;
        private System.Windows.Forms.RadioButton admin_radio_id;
        private System.Windows.Forms.RadioButton customer_radio_id;
        private System.Windows.Forms.TextBox username_textbox_id;
        private System.Windows.Forms.TextBox password_textbox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}