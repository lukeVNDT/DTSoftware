namespace QLHV
{
    partial class Formlichhoc
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
            this.flppanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lb = new System.Windows.Forms.Label();
            this.txtphong = new System.Windows.Forms.TextBox();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.cbbthu = new System.Windows.Forms.ComboBox();
            this.dtpngay = new System.Windows.Forms.DateTimePicker();
            this.cbbtrangthai = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flppanel
            // 
            this.flppanel.AutoScroll = true;
            this.flppanel.Location = new System.Drawing.Point(12, 77);
            this.flppanel.Name = "flppanel";
            this.flppanel.Size = new System.Drawing.Size(722, 493);
            this.flppanel.TabIndex = 0;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(558, 9);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(81, 20);
            this.lb.TabIndex = 1;
            this.lb.Text = "Lịch học";
            // 
            // txtphong
            // 
            this.txtphong.Location = new System.Drawing.Point(954, 220);
            this.txtphong.Name = "txtphong";
            this.txtphong.Size = new System.Drawing.Size(197, 22);
            this.txtphong.TabIndex = 2;
            // 
            // cbblop
            // 
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(957, 70);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(115, 24);
            this.cbblop.TabIndex = 3;
            // 
            // cbbthu
            // 
            this.cbbthu.FormattingEnabled = true;
            this.cbbthu.Location = new System.Drawing.Point(958, 114);
            this.cbbthu.Name = "cbbthu";
            this.cbbthu.Size = new System.Drawing.Size(121, 24);
            this.cbbthu.TabIndex = 4;
            // 
            // dtpngay
            // 
            this.dtpngay.CustomFormat = "dd/MM/yyyy";
            this.dtpngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngay.Location = new System.Drawing.Point(958, 166);
            this.dtpngay.Name = "dtpngay";
            this.dtpngay.Size = new System.Drawing.Size(200, 22);
            this.dtpngay.TabIndex = 5;
            // 
            // cbbtrangthai
            // 
            this.cbbtrangthai.FormattingEnabled = true;
            this.cbbtrangthai.Location = new System.Drawing.Point(957, 269);
            this.cbbtrangthai.Name = "cbbtrangthai";
            this.cbbtrangthai.Size = new System.Drawing.Size(194, 24);
            this.cbbtrangthai.TabIndex = 6;
            // 
            // btnadd
            // 
            this.btnadd.Image = global::QLHV.Properties.Resources._001_01;
            this.btnadd.Location = new System.Drawing.Point(957, 335);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(50, 50);
            this.btnadd.TabIndex = 7;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1052, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formlichhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1184, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbbtrangthai);
            this.Controls.Add(this.dtpngay);
            this.Controls.Add(this.cbbthu);
            this.Controls.Add(this.cbblop);
            this.Controls.Add(this.txtphong);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.flppanel);
            this.Name = "Formlichhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formlichhoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flppanel;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtphong;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.ComboBox cbbthu;
        private System.Windows.Forms.DateTimePicker dtpngay;
        private System.Windows.Forms.ComboBox cbbtrangthai;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
    }
}