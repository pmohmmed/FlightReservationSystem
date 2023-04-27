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
            this.SuspendLayout();
            // 
            // customer_button_id
            // 
            this.customer_button_id.Location = new System.Drawing.Point(295, 148);
            this.customer_button_id.Name = "customer_button_id";
            this.customer_button_id.Size = new System.Drawing.Size(98, 23);
            this.customer_button_id.TabIndex = 0;
            this.customer_button_id.Text = "customer";
            this.customer_button_id.UseVisualStyleBackColor = true;
            // 
            // admin_button_id
            // 
            this.admin_button_id.Location = new System.Drawing.Point(441, 148);
            this.admin_button_id.Name = "admin_button_id";
            this.admin_button_id.Size = new System.Drawing.Size(75, 23);
            this.admin_button_id.TabIndex = 1;
            this.admin_button_id.Text = "admin";
            this.admin_button_id.UseVisualStyleBackColor = true;
            // 
            // connected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.admin_button_id);
            this.Controls.Add(this.customer_button_id);
            this.Name = "connected";
            this.Text = "connected";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer_button_id;
        private System.Windows.Forms.Button admin_button_id;
    }
}