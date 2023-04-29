namespace FlightReservationSys
{
    partial class flight_info
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
            this.adminUserName_TB = new System.Windows.Forms.TextBox();
            this.password_TB = new System.Windows.Forms.TextBox();
            this.userName_L = new System.Windows.Forms.Label();
            this.password_L = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.save_B = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminUserName_TB
            // 
            this.adminUserName_TB.Location = new System.Drawing.Point(130, 28);
            this.adminUserName_TB.Name = "adminUserName_TB";
            this.adminUserName_TB.Size = new System.Drawing.Size(178, 22);
            this.adminUserName_TB.TabIndex = 0;
            // 
            // password_TB
            // 
            this.password_TB.Location = new System.Drawing.Point(130, 57);
            this.password_TB.Name = "password_TB";
            this.password_TB.Size = new System.Drawing.Size(178, 22);
            this.password_TB.TabIndex = 1;
            // 
            // userName_L
            // 
            this.userName_L.AutoSize = true;
            this.userName_L.Location = new System.Drawing.Point(13, 28);
            this.userName_L.Name = "userName_L";
            this.userName_L.Size = new System.Drawing.Size(111, 16);
            this.userName_L.TabIndex = 2;
            this.userName_L.Text = "Admin user name";
            // 
            // password_L
            // 
            this.password_L.AutoSize = true;
            this.password_L.Location = new System.Drawing.Point(13, 58);
            this.password_L.Name = "password_L";
            this.password_L.Size = new System.Drawing.Size(67, 16);
            this.password_L.TabIndex = 3;
            this.password_L.Text = "Password";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1022, 364);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Added Flights";
            // 
            // save_B
            // 
            this.save_B.Location = new System.Drawing.Point(387, 494);
            this.save_B.Name = "save_B";
            this.save_B.Size = new System.Drawing.Size(143, 44);
            this.save_B.TabIndex = 6;
            this.save_B.Text = "Save";
            this.save_B.UseVisualStyleBackColor = true;
            this.save_B.Click += new System.EventHandler(this.save_B_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get Flights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flight_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.password_L);
            this.Controls.Add(this.userName_L);
            this.Controls.Add(this.password_TB);
            this.Controls.Add(this.adminUserName_TB);
            this.Name = "flight_info";
            this.Text = "flight_info";
            this.Load += new System.EventHandler(this.flight_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminUserName_TB;
        private System.Windows.Forms.TextBox password_TB;
        private System.Windows.Forms.Label userName_L;
        private System.Windows.Forms.Label password_L;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_B;
        private System.Windows.Forms.Button button1;
    }
}