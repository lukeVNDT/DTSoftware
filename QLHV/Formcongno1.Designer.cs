namespace QLHV
{
    partial class Formrpcongno1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.btnin = new System.Windows.Forms.Button();
            this.qlhvDataSet2 = new QLHV.qlhvDataSet2();
            this.congnobylopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.congnobylopTableAdapter = new QLHV.qlhvDataSet2TableAdapters.congnobylopTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnobylopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.congnobylopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLHV.Reportcnhv.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1138, 491);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Công nợ học viên";
            // 
            // cbblop
            // 
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(12, 50);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(115, 24);
            this.cbblop.TabIndex = 2;
            // 
            // btnin
            // 
            this.btnin.Image = global::QLHV.Properties.Resources.print_102332;
            this.btnin.Location = new System.Drawing.Point(133, 36);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(50, 50);
            this.btnin.TabIndex = 3;
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // qlhvDataSet2
            // 
            this.qlhvDataSet2.DataSetName = "qlhvDataSet2";
            this.qlhvDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // congnobylopBindingSource
            // 
            this.congnobylopBindingSource.DataMember = "congnobylop";
            this.congnobylopBindingSource.DataSource = this.qlhvDataSet2;
            // 
            // congnobylopTableAdapter
            // 
            this.congnobylopTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lớp:";
            // 
            // Formrpcongno1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1164, 641);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.cbblop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Formrpcongno1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formcongno1";
            this.Load += new System.EventHandler(this.Formcongno1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnobylopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.BindingSource congnobylopBindingSource;
        private qlhvDataSet2 qlhvDataSet2;
        private qlhvDataSet2TableAdapters.congnobylopTableAdapter congnobylopTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}