namespace FlightReservationSys
{
    partial class main_form_id
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
            this.connected_button_id = new System.Windows.Forms.Button();
            this.disconnected_button_id = new System.Windows.Forms.Button();
            this.crystal_button_id = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connected_button_id
            // 
            this.connected_button_id.Location = new System.Drawing.Point(254, 154);
            this.connected_button_id.Name = "connected_button_id";
            this.connected_button_id.Size = new System.Drawing.Size(75, 23);
            this.connected_button_id.TabIndex = 1;
            this.connected_button_id.Text = "connected";
            this.connected_button_id.UseVisualStyleBackColor = true;
            // 
            // disconnected_button_id
            // 
            this.disconnected_button_id.Location = new System.Drawing.Point(348, 154);
            this.disconnected_button_id.Name = "disconnected_button_id";
            this.disconnected_button_id.Size = new System.Drawing.Size(75, 23);
            this.disconnected_button_id.TabIndex = 2;
            this.disconnected_button_id.Text = "disconnected";
            this.disconnected_button_id.UseVisualStyleBackColor = true;
            // 
            // crystal_button_id
            // 
            this.crystal_button_id.Location = new System.Drawing.Point(449, 154);
            this.crystal_button_id.Name = "crystal_button_id";
            this.crystal_button_id.Size = new System.Drawing.Size(75, 23);
            this.crystal_button_id.TabIndex = 3;
            this.crystal_button_id.Text = "crystal";
            this.crystal_button_id.UseVisualStyleBackColor = true;
            // 
            // main_form_id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystal_button_id);
            this.Controls.Add(this.disconnected_button_id);
            this.Controls.Add(this.connected_button_id);
            this.Name = "main_form_id";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_form_id_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connected_button_id;
        private System.Windows.Forms.Button disconnected_button_id;
        private System.Windows.Forms.Button crystal_button_id;
    }
}

