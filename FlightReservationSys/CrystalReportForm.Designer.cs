
namespace FlightReservationSys
{
    partial class CrystalReportForm
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
            this.generate_btn_id = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_name_category_cmb_id = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ordinal_report = new System.Windows.Forms.Button();
            this.Summrized_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate_btn_id
            // 
            this.generate_btn_id.Location = new System.Drawing.Point(468, 22);
            this.generate_btn_id.Name = "generate_btn_id";
            this.generate_btn_id.Size = new System.Drawing.Size(147, 23);
            this.generate_btn_id.TabIndex = 0;
            this.generate_btn_id.Text = "GenerateReport";
            this.generate_btn_id.UseVisualStyleBackColor = true;
            this.generate_btn_id.Click += new System.EventHandler(this.generate_report_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // user_name_category_cmb_id
            // 
            this.user_name_category_cmb_id.FormattingEnabled = true;
            this.user_name_category_cmb_id.Location = new System.Drawing.Point(326, 21);
            this.user_name_category_cmb_id.Name = "user_name_category_cmb_id";
            this.user_name_category_cmb_id.Size = new System.Drawing.Size(121, 24);
            this.user_name_category_cmb_id.TabIndex = 2;
            this.user_name_category_cmb_id.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 51);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1537, 656);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // ordinal_report
            // 
            this.ordinal_report.Location = new System.Drawing.Point(682, 22);
            this.ordinal_report.Name = "ordinal_report";
            this.ordinal_report.Size = new System.Drawing.Size(130, 23);
            this.ordinal_report.TabIndex = 4;
            this.ordinal_report.Text = "Ordinal Report";
            this.ordinal_report.UseVisualStyleBackColor = true;
            this.ordinal_report.Click += new System.EventHandler(this.ordinal_report_Click);
            // 
            // Summrized_report
            // 
            this.Summrized_report.Location = new System.Drawing.Point(844, 22);
            this.Summrized_report.Name = "Summrized_report";
            this.Summrized_report.Size = new System.Drawing.Size(149, 23);
            this.Summrized_report.TabIndex = 5;
            this.Summrized_report.Text = "Summrized Report";
            this.Summrized_report.UseVisualStyleBackColor = true;
            this.Summrized_report.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrystalReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 719);
            this.Controls.Add(this.Summrized_report);
            this.Controls.Add(this.ordinal_report);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.user_name_category_cmb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generate_btn_id);
            this.Name = "CrystalReportForm";
            this.Text = "CrystalReport";
            this.Load += new System.EventHandler(this.CrystalReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_btn_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox user_name_category_cmb_id;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button ordinal_report;
        private System.Windows.Forms.Button Summrized_report;
    }
}