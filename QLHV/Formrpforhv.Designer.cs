namespace QLHV
{
    partial class Formrpforhv
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
            this.txtmahv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qlhvDataSet3 = new QLHV.qlhvDataSet3();
            this.congnobymahvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.congnobymahvTableAdapter = new QLHV.qlhvDataSet3TableAdapters.congnobymahvTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnobymahvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmahv
            // 
            this.txtmahv.Location = new System.Drawing.Point(12, 73);
            this.txtmahv.Name = "txtmahv";
            this.txtmahv.ReadOnly = true;
            this.txtmahv.Size = new System.Drawing.Size(144, 22);
            this.txtmahv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã học viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "In công nợ học viên";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.congnobymahvBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLHV.Reportcnbymahv.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1150, 453);
            this.reportViewer1.TabIndex = 3;
            // 
            // qlhvDataSet3
            // 
            this.qlhvDataSet3.DataSetName = "qlhvDataSet3";
            this.qlhvDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // congnobymahvBindingSource
            // 
            this.congnobymahvBindingSource.DataMember = "congnobymahv";
            this.congnobymahvBindingSource.DataSource = this.qlhvDataSet3;
            // 
            // congnobymahvTableAdapter
            // 
            this.congnobymahvTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Image = global::QLHV.Properties.Resources.print_102332;
            this.button1.Location = new System.Drawing.Point(162, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formrpforhv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1177, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmahv);
            this.Name = "Formrpforhv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formrpforhv";
            this.Load += new System.EventHandler(this.Formrpforhv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qlhvDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congnobymahvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmahv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource congnobymahvBindingSource;
        private qlhvDataSet3 qlhvDataSet3;
        private qlhvDataSet3TableAdapters.congnobymahvTableAdapter congnobymahvTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}