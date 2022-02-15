namespace QLHV
{
    partial class Formrpdiemdanh
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnin = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlhvDataSet = new QLHV.qlhvDataSet();
            this.allttforrp5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allttforrp5TableAdapter = new QLHV.qlhvDataSetTableAdapters.allttforrp5TableAdapter();
            this.qlhvDataSet1 = new QLHV.qlhvDataSet1();
            this.lopvatgforrpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopvatgforrpTableAdapter = new QLHV.qlhvDataSet1TableAdapters.lopvatgforrpTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrp5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopvatgforrpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày:";
            // 
            // cbblop
            // 
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(15, 74);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(88, 24);
            this.cbblop.TabIndex = 3;
            // 
            // dtpngay
            // 
            this.dtpngay.CustomFormat = "dd/MM/yyyy";
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngay.Location = new System.Drawing.Point(173, 76);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(146, 22);
            this.dtpngay.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "In thông tin điểm danh";
            // 
            // btnin
            // 
            this.btnin.Image = global::QLHV.Properties.Resources.print_102332;
            this.btnin.Location = new System.Drawing.Point(325, 60);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(50, 50);
            this.btnin.TabIndex = 2;
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lopvatgforrpBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLHV.Reportdd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 120);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(955, 399);
            this.reportViewer1.TabIndex = 6;
            // 
            // qlhvDataSet
            // 
            this.qlhvDataSet.DataSetName = "qlhvDataSet";
            this.qlhvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allttforrp5BindingSource
            // 
            this.allttforrp5BindingSource.DataMember = "allttforrp5";
            this.allttforrp5BindingSource.DataSource = this.qlhvDataSet;
            // 
            // allttforrp5TableAdapter
            // 
            this.allttforrp5TableAdapter.ClearBeforeFill = true;
            // 
            // qlhvDataSet1
            // 
            this.qlhvDataSet1.DataSetName = "qlhvDataSet1";
            this.qlhvDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopvatgforrpBindingSource
            // 
            this.lopvatgforrpBindingSource.DataMember = "lopvatgforrp";
            this.lopvatgforrpBindingSource.DataSource = this.qlhvDataSet1;
            // 
            // lopvatgforrpTableAdapter
            // 
            this.lopvatgforrpTableAdapter.ClearBeforeFill = true;
            // 
            // Formrpdiemdanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(989, 534);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpngay);
            this.Controls.Add(this.cbblop);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formrpdiemdanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo điểm danh";
            this.Load += new System.EventHandler(this.Formrpdiemdanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrp5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopvatgforrpBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.DateTimePicker dtpngay;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource allttforrp5BindingSource;
        private qlhvDataSet qlhvDataSet;
        private qlhvDataSetTableAdapters.allttforrp5TableAdapter allttforrp5TableAdapter;
        private System.Windows.Forms.BindingSource lopvatgforrpBindingSource;
        private qlhvDataSet1 qlhvDataSet1;
        private qlhvDataSet1TableAdapters.lopvatgforrpTableAdapter lopvatgforrpTableAdapter;
    }
}