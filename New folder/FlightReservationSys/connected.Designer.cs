namespace FlightReservationSys
{
    partial class connected
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
            this.customer_button_id = new System.Windows.Forms.Button();
            this.admin_button_id = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // customer_button_id
            // 
            this.customer_button_id.Location = new System.Drawing.Point(393, 182);
            this.customer_button_id.Margin = new System.Windows.Forms.Padding(4);
            this.customer_button_id.Name = "customer_button_id";
            this.customer_button_id.Size = new System.Drawing.Size(131, 28);
            this.customer_button_id.TabIndex = 0;
            this.customer_button_id.Text = "customer";
            this.customer_button_id.UseVisualStyleBackColor = true;
            this.customer_button_id.Click += new System.EventHandler(this.customer_button_id_Click);
            // 
            // admin_button_id
            // 
            this.admin_button_id.Location = new System.Drawing.Point(588, 182);
            this.admin_button_id.Margin = new System.Windows.Forms.Padding(4);
            this.admin_button_id.Name = "admin_button_id";
            this.admin_button_id.Size = new System.Drawing.Size(100, 28);
            this.admin_button_id.TabIndex = 1;
            this.admin_button_id.Text = "admin";
            this.admin_button_id.UseVisualStyleBackColor = true;
            this.admin_button_id.Click += new System.EventHandler(this.admin_button_id_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(475, 308);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(475, 334);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // connected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.admin_button_id);
            this.Controls.Add(this.customer_button_id);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "connected";
            this.Text = "connected";
            this.Load += new System.EventHandler(this.connected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customer_button_id;
        private System.Windows.Forms.Button admin_button_id;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}