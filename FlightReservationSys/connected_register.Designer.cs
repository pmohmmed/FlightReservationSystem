namespace FlightReservationSys
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
            this.password_textbox_id = new System.Windows.Forms.TextBox();
            this.username_textbox_id = new System.Windows.Forms.TextBox();
            this.company_textbox_id = new System.Windows.Forms.TextBox();
            this.password_label_id = new System.Windows.Forms.Label();
            this.company_label_id = new System.Windows.Forms.Label();
            this.username_label_id = new System.Windows.Forms.Label();
            this.register_button_id = new System.Windows.Forms.Button();
            this.admin_radio_id = new System.Windows.Forms.RadioButton();
            this.customer_radio_id = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customer_radio_id);
            this.groupBox1.Controls.Add(this.admin_radio_id);
            this.groupBox1.Controls.Add(this.register_button_id);
            this.groupBox1.Controls.Add(this.company_label_id);
            this.groupBox1.Controls.Add(this.company_textbox_id);
            this.groupBox1.Controls.Add(this.username_label_id);
            this.groupBox1.Controls.Add(this.password_label_id);
            this.groupBox1.Controls.Add(this.username_textbox_id);
            this.groupBox1.Controls.Add(this.password_textbox_id);
            this.groupBox1.Location = new System.Drawing.Point(289, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // password_textbox_id
            // 
            this.password_textbox_id.Location = new System.Drawing.Point(95, 94);
            this.password_textbox_id.Name = "password_textbox_id";
            this.password_textbox_id.Size = new System.Drawing.Size(158, 20);
            this.password_textbox_id.TabIndex = 2;
            // 
            // username_textbox_id
            // 
            this.username_textbox_id.Location = new System.Drawing.Point(95, 68);
            this.username_textbox_id.Name = "username_textbox_id";
            this.username_textbox_id.Size = new System.Drawing.Size(158, 20);
            this.username_textbox_id.TabIndex = 3;
            // 
            // company_textbox_id
            // 
            this.company_textbox_id.Location = new System.Drawing.Point(95, 120);
            this.company_textbox_id.Name = "company_textbox_id";
            this.company_textbox_id.Size = new System.Drawing.Size(158, 20);
            this.company_textbox_id.TabIndex = 4;
            // 
            // password_label_id
            // 
            this.password_label_id.AutoSize = true;
            this.password_label_id.Location = new System.Drawing.Point(28, 94);
            this.password_label_id.Name = "password_label_id";
            this.password_label_id.Size = new System.Drawing.Size(52, 13);
            this.password_label_id.TabIndex = 5;
            this.password_label_id.Text = "password";
            // 
            // company_label_id
            // 
            this.company_label_id.AutoSize = true;
            this.company_label_id.Location = new System.Drawing.Point(30, 123);
            this.company_label_id.Name = "company_label_id";
            this.company_label_id.Size = new System.Drawing.Size(50, 13);
            this.company_label_id.TabIndex = 6;
            this.company_label_id.Text = "company";
            // 
            // username_label_id
            // 
            this.username_label_id.AutoSize = true;
            this.username_label_id.Location = new System.Drawing.Point(27, 68);
            this.username_label_id.Name = "username_label_id";
            this.username_label_id.Size = new System.Drawing.Size(53, 13);
            this.username_label_id.TabIndex = 7;
            this.username_label_id.Text = "username";
            this.username_label_id.Click += new System.EventHandler(this.label3_Click);
            // 
            // register_button_id
            // 
            this.register_button_id.Location = new System.Drawing.Point(141, 194);
            this.register_button_id.Name = "register_button_id";
            this.register_button_id.Size = new System.Drawing.Size(65, 30);
            this.register_button_id.TabIndex = 8;
            this.register_button_id.Text = "register";
            this.register_button_id.UseVisualStyleBackColor = true;
            this.register_button_id.Click += new System.EventHandler(this.register_button_id_Click);
            // 
            // admin_radio_id
            // 
            this.admin_radio_id.AutoSize = true;
            this.admin_radio_id.Location = new System.Drawing.Point(95, 159);
            this.admin_radio_id.Name = "admin_radio_id";
            this.admin_radio_id.Size = new System.Drawing.Size(53, 17);
            this.admin_radio_id.TabIndex = 9;
            this.admin_radio_id.TabStop = true;
            this.admin_radio_id.Text = "admin";
            this.admin_radio_id.UseVisualStyleBackColor = true;
            this.admin_radio_id.CheckedChanged += new System.EventHandler(this.admin_radio_id_CheckedChanged);
            // 
            // customer_radio_id
            // 
            this.customer_radio_id.AutoSize = true;
            this.customer_radio_id.Location = new System.Drawing.Point(196, 159);
            this.customer_radio_id.Name = "customer_radio_id";
            this.customer_radio_id.Size = new System.Drawing.Size(68, 17);
            this.customer_radio_id.TabIndex = 10;
            this.customer_radio_id.TabStop = true;
            this.customer_radio_id.Text = "customer";
            this.customer_radio_id.UseVisualStyleBackColor = true;
            this.customer_radio_id.CheckedChanged += new System.EventHandler(this.customer_radio_id_CheckedChanged);
            // 
            // connected_register_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "connected_register_form";
            this.Text = "register";
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
    }
}