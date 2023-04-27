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
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connected_button_id
            // 
            this.connected_button_id.Location = new System.Drawing.Point(339, 190);
            this.connected_button_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connected_button_id.Name = "connected_button_id";
            this.connected_button_id.Size = new System.Drawing.Size(100, 28);
            this.connected_button_id.TabIndex = 1;
            this.connected_button_id.Text = "connected";
            this.connected_button_id.UseVisualStyleBackColor = true;
            // 
            // disconnected_button_id
            // 
            this.disconnected_button_id.Location = new System.Drawing.Point(464, 190);
            this.disconnected_button_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disconnected_button_id.Name = "disconnected_button_id";
            this.disconnected_button_id.Size = new System.Drawing.Size(100, 28);
            this.disconnected_button_id.TabIndex = 2;
            this.disconnected_button_id.Text = "disconnected";
            this.disconnected_button_id.UseVisualStyleBackColor = true;
            // 
            // crystal_button_id
            // 
            this.crystal_button_id.Location = new System.Drawing.Point(599, 190);
            this.crystal_button_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.crystal_button_id.Name = "crystal_button_id";
            this.crystal_button_id.Size = new System.Drawing.Size(100, 28);
            this.crystal_button_id.TabIndex = 3;
            this.crystal_button_id.Text = "crystal";
            this.crystal_button_id.UseVisualStyleBackColor = true;
            // 
            // comboBox_id
            // 
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Location = new System.Drawing.Point(516, 90);
            this.comboBox_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(160, 24);
            this.comboBox_id.TabIndex = 4;
            this.comboBox_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_id_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "test oracle connection";
            // 
            // main_form_id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_id);
            this.Controls.Add(this.crystal_button_id);
            this.Controls.Add(this.disconnected_button_id);
            this.Controls.Add(this.connected_button_id);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "main_form_id";
            this.Text = "main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_form_closing);
            this.Load += new System.EventHandler(this.main_form_id_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connected_button_id;
        private System.Windows.Forms.Button disconnected_button_id;
        private System.Windows.Forms.Button crystal_button_id;
        private System.Windows.Forms.ComboBox comboBox_id;
        private System.Windows.Forms.Label label1;
    }
}

