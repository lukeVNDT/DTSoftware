namespace QLHV
{
    partial class Formrp
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
            this.allttforrp5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qlhvDataSet = new QLHV.qlhvDataSet();
            this.allttforrp3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allttforrpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.allttBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btntrove = new System.Windows.Forms.Button();
            this.allttforrp2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.allttforrp5TableAdapter = new QLHV.qlhvDataSetTableAdapters.allttforrp5TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrp5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrp3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrpBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrp2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allttforrp5BindingSource
            // 
            this.allttforrp5BindingSource.DataMember = "allttforrp5";
            this.allttforrp5BindingSource.DataSource = this.qlhvDataSet;
            // 
            // qlhvDataSet
            // 
            this.qlhvDataSet.DataSetName = "qlhvDataSet";
            this.qlhvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allttforrp3BindingSource
            // 
            this.allttforrp3BindingSource.DataMember = "allttforrp3";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.allttforrp5BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLHV.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1028, 431);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ReportExport += new Microsoft.Reporting.WinForms.ExportEventHandler(this.reportViewer1_ReportExport);
            this.reportViewer1.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.reportViewer1_ReportRefresh);
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "In danh sách học viên";
            // 
            // allttBindingSource
            // 
            this.allttBindingSource.DataMember = "alltt";
            // 
            // btntrove
            // 
            this.btntrove.Image = global::QLHV.Properties.Resources._001_23;
            this.btntrove.Location = new System.Drawing.Point(992, 546);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(51, 35);
            this.btntrove.TabIndex = 2;
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // allttforrp2BindingSource
            // 
            this.allttforrp2BindingSource.DataMember = "allttforrp2";
            // 
            // button1
            // 
            this.button1.Image = global::QLHV.Properties.Resources.print_102332;
            this.button1.Location = new System.Drawing.Point(242, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 44);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = " Chọn lớp bạn muốn in danh sách:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // allttforrp5TableAdapter
            // 
            this.allttforrp5TableAdapter.ClearBeforeFill = true;
            // 
            // Formrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1062, 593);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Formrp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In danh sách học viên";
            this.Load += new System.EventHandler(this.Formrp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allttforrp5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrp3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrpBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allttforrp2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource allttBindingSource;
        //private qlhvDataSet qlhvDataSet;
        //private qlhvDataSetTableAdapters.allttTableAdapter allttTableAdapter;
        //private qlhvDataSet2 qlhvDataSet2;
        private System.Windows.Forms.BindingSource allttforrpBindingSource;
        //private qlhvDataSet2TableAdapters.allttforrpTableAdapter allttforrpTableAdapter;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.BindingSource allttforrp2BindingSource;
        //private qlhvDataSet3 qlhvDataSet3;
        //private qlhvDataSet3TableAdapters.allttforrp2TableAdapter allttforrp2TableAdapter;
        //private qlhvDataSet4 qlhvDataSet4;
       // private qlhvDataSet1 qlhvDataSet1;
        private System.Windows.Forms.BindingSource allttforrp3BindingSource;
        //private qlhvDataSet5 qlhvDataSet5;
        //private qlhvDataSet5TableAdapters.allttforrp3TableAdapter allttforrp3TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource allttforrp5BindingSource;
        private qlhvDataSet qlhvDataSet;
        private qlhvDataSetTableAdapters.allttforrp5TableAdapter allttforrp5TableAdapter;
    }
}