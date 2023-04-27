namespace FlightReservationSys
{
    partial class cutomer
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
            this.search_button_id = new System.Windows.Forms.Button();
            this.cancel_button_id = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search_button_id
            // 
            this.search_button_id.Location = new System.Drawing.Point(302, 116);
            this.search_button_id.Name = "search_button_id";
            this.search_button_id.Size = new System.Drawing.Size(75, 23);
            this.search_button_id.TabIndex = 0;
            this.search_button_id.Text = "search";
            this.search_button_id.UseVisualStyleBackColor = true;
            this.search_button_id.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel_button_id
            // 
            this.cancel_button_id.Location = new System.Drawing.Point(427, 115);
            this.cancel_button_id.Name = "cancel_button_id";
            this.cancel_button_id.Size = new System.Drawing.Size(75, 23);
            this.cancel_button_id.TabIndex = 1;
            this.cancel_button_id.Text = "cancel";
            this.cancel_button_id.UseVisualStyleBackColor = true;
            // 
            // cutomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_button_id);
            this.Controls.Add(this.search_button_id);
            this.Name = "cutomer";
            this.Text = "cutomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button search_button_id;
        private System.Windows.Forms.Button cancel_button_id;
    }
}