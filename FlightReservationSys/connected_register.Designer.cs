﻿namespace FlightReservationSys
{
    partial class connected_register_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login_button_id = new System.Windows.Forms.Button();
            this.customer_radio_id = new System.Windows.Forms.RadioButton();
            this.admin_radio_id = new System.Windows.Forms.RadioButton();
            this.register_button_id = new System.Windows.Forms.Button();
            this.company_label_id = new System.Windows.Forms.Label();
            this.company_textbox_id = new System.Windows.Forms.TextBox();
            this.username_label_id = new System.Windows.Forms.Label();
            this.password_label_id = new System.Windows.Forms.Label();
            this.username_textbox_id = new System.Windows.Forms.TextBox();
            this.password_textbox_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.login_button_id);
            this.groupBox1.Controls.Add(this.customer_radio_id);
            this.groupBox1.Controls.Add(this.admin_radio_id);
            this.groupBox1.Controls.Add(this.register_button_id);
            this.groupBox1.Controls.Add(this.company_label_id);
            this.groupBox1.Controls.Add(this.company_textbox_id);
            this.groupBox1.Controls.Add(this.username_label_id);
            this.groupBox1.Controls.Add(this.password_label_id);
            this.groupBox1.Controls.Add(this.username_textbox_id);
            this.groupBox1.Controls.Add(this.password_textbox_id);
            this.groupBox1.Location = new System.Drawing.Point(-3, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "---- u have an account ? ---";
            // 
            // login_button_id
            // 
            this.login_button_id.Location = new System.Drawing.Point(132, 233);
            this.login_button_id.Name = "login_button_id";
            this.login_button_id.Size = new System.Drawing.Size(60, 25);
            this.login_button_id.TabIndex = 7;
            this.login_button_id.Text = "login";
            this.login_button_id.UseVisualStyleBackColor = true;
            this.login_button_id.Click += new System.EventHandler(this.login_button_id_Click);
            // 
            // customer_radio_id
            // 
            this.customer_radio_id.AutoSize = true;
            this.customer_radio_id.Location = new System.Drawing.Point(132, 135);
            this.customer_radio_id.Name = "customer_radio_id";
            this.customer_radio_id.Size = new System.Drawing.Size(68, 17);
            this.customer_radio_id.TabIndex = 5;
            this.customer_radio_id.TabStop = true;
            this.customer_radio_id.Text = "customer";
            this.customer_radio_id.UseVisualStyleBackColor = true;
            this.customer_radio_id.CheckedChanged += new System.EventHandler(this.customer_radio_id_CheckedChanged);
            // 
            // admin_radio_id
            // 
            this.admin_radio_id.AutoSize = true;
            this.admin_radio_id.Location = new System.Drawing.Point(63, 135);
            this.admin_radio_id.Name = "admin_radio_id";
            this.admin_radio_id.Size = new System.Drawing.Size(53, 17);
            this.admin_radio_id.TabIndex = 4;
            this.admin_radio_id.TabStop = true;
            this.admin_radio_id.Text = "admin";
            this.admin_radio_id.UseVisualStyleBackColor = true;
            this.admin_radio_id.CheckedChanged += new System.EventHandler(this.admin_radio_id_CheckedChanged);
            // 
            // register_button_id
            // 
            this.register_button_id.Location = new System.Drawing.Point(63, 172);
            this.register_button_id.Name = "register_button_id";
            this.register_button_id.Size = new System.Drawing.Size(207, 30);
            this.register_button_id.TabIndex = 6;
            this.register_button_id.Text = "register";
            this.register_button_id.UseVisualStyleBackColor = true;
            this.register_button_id.Click += new System.EventHandler(this.register_button_id_Click);
            // 
            // company_label_id
            // 
            this.company_label_id.AutoSize = true;
            this.company_label_id.Location = new System.Drawing.Point(7, 99);
            this.company_label_id.Name = "company_label_id";
            this.company_label_id.Size = new System.Drawing.Size(50, 13);
            this.company_label_id.TabIndex = 6;
            this.company_label_id.Text = "company";
            this.company_label_id.Visible = false;
            // 
            // company_textbox_id
            // 
            this.company_textbox_id.Location = new System.Drawing.Point(63, 96);
            this.company_textbox_id.Name = "company_textbox_id";
            this.company_textbox_id.Size = new System.Drawing.Size(207, 20);
            this.company_textbox_id.TabIndex = 3;
            this.company_textbox_id.Visible = false;
            // 
            // username_label_id
            // 
            this.username_label_id.AutoSize = true;
            this.username_label_id.Location = new System.Drawing.Point(7, 44);
            this.username_label_id.Name = "username_label_id";
            this.username_label_id.Size = new System.Drawing.Size(53, 13);
            this.username_label_id.TabIndex = 7;
            this.username_label_id.Text = "username";
            this.username_label_id.Click += new System.EventHandler(this.label3_Click);
            // 
            // password_label_id
            // 
            this.password_label_id.AutoSize = true;
            this.password_label_id.Location = new System.Drawing.Point(8, 73);
            this.password_label_id.Name = "password_label_id";
            this.password_label_id.Size = new System.Drawing.Size(52, 13);
            this.password_label_id.TabIndex = 5;
            this.password_label_id.Text = "password";
            // 
            // username_textbox_id
            // 
            this.username_textbox_id.Location = new System.Drawing.Point(63, 44);
            this.username_textbox_id.Name = "username_textbox_id";
            this.username_textbox_id.Size = new System.Drawing.Size(207, 20);
            this.username_textbox_id.TabIndex = 1;
            // 
            // password_textbox_id
            // 
            this.password_textbox_id.Location = new System.Drawing.Point(63, 70);
            this.password_textbox_id.Name = "password_textbox_id";
            this.password_textbox_id.Size = new System.Drawing.Size(207, 20);
            this.password_textbox_id.TabIndex = 2;
            // 
            // connected_register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "connected_register_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.register_form_closing);
            this.Load += new System.EventHandler(this.connected_register_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button register_button_id;
        private System.Windows.Forms.Label username_label_id;
        private System.Windows.Forms.Label company_label_id;
        private System.Windows.Forms.Label password_label_id;
        private System.Windows.Forms.TextBox company_textbox_id;
        private System.Windows.Forms.TextBox username_textbox_id;
        private System.Windows.Forms.TextBox password_textbox_id;
        private System.Windows.Forms.RadioButton customer_radio_id;
        private System.Windows.Forms.RadioButton admin_radio_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_button_id;
    }
}