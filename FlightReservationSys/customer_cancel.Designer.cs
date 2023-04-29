namespace FlightReservationSys
{
    partial class customer_cancel
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sourceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destinationTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cardNumTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.companyNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booked-Flights-ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.cancel_flight);
            // 
            // sourceTB
            // 
            this.sourceTB.Location = new System.Drawing.Point(148, 222);
            this.sourceTB.Name = "sourceTB";
            this.sourceTB.ReadOnly = true;
            this.sourceTB.Size = new System.Drawing.Size(181, 22);
            this.sourceTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destination";
            // 
            // destinationTB
            // 
            this.destinationTB.Location = new System.Drawing.Point(148, 268);
            this.destinationTB.Name = "destinationTB";
            this.destinationTB.ReadOnly = true;
            this.destinationTB.Size = new System.Drawing.Size(181, 22);
            this.destinationTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(148, 314);
            this.priceTB.Name = "priceTB";
            this.priceTB.ReadOnly = true;
            this.priceTB.Size = new System.Drawing.Size(181, 22);
            this.priceTB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date-Time";
            // 
            // dateTimeTB
            // 
            this.dateTimeTB.Location = new System.Drawing.Point(525, 219);
            this.dateTimeTB.Name = "dateTimeTB";
            this.dateTimeTB.ReadOnly = true;
            this.dateTimeTB.Size = new System.Drawing.Size(181, 22);
            this.dateTimeTB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(391, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Used Card Number";
            // 
            // cardNumTB
            // 
            this.cardNumTB.Location = new System.Drawing.Point(525, 268);
            this.cardNumTB.Name = "cardNumTB";
            this.cardNumTB.ReadOnly = true;
            this.cardNumTB.Size = new System.Drawing.Size(181, 22);
            this.cardNumTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Company Name";
            // 
            // companyNameTB
            // 
            this.companyNameTB.Location = new System.Drawing.Point(525, 314);
            this.companyNameTB.Name = "companyNameTB";
            this.companyNameTB.ReadOnly = true;
            this.companyNameTB.Size = new System.Drawing.Size(181, 22);
            this.companyNameTB.TabIndex = 13;
            // 
            // customer_cancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.companyNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cardNumTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinationTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "customer_cancel";
            this.Text = "customer_cancel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.customer_cancel_FormClosing);
            this.Load += new System.EventHandler(this.customer_cancel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sourceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox destinationTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateTimeTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cardNumTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox companyNameTB;
    }
}
