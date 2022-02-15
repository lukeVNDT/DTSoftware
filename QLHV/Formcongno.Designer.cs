namespace QLHV
{
    partial class Formcongno
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
            this.dgvcongno = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.dtpbd = new System.Windows.Forms.DateTimePicker();
            this.dtpkt = new System.Windows.Forms.DateTimePicker();
            this.txttien = new System.Windows.Forms.TextBox();
            this.txtmahv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcongno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcongno
            // 
            this.dgvcongno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcongno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcongno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcongno.Location = new System.Drawing.Point(12, 107);
            this.dgvcongno.Name = "dgvcongno";
            this.dgvcongno.RowHeadersWidth = 51;
            this.dgvcongno.RowTemplate.Height = 24;
            this.dgvcongno.Size = new System.Drawing.Size(776, 395);
            this.dgvcongno.TabIndex = 0;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(12, 67);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(196, 22);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbblop
            // 
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(604, 67);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(121, 24);
            this.cbblop.TabIndex = 2;
            // 
            // dtpbd
            // 
            this.dtpbd.CustomFormat = "dd/MM/yyyy";
            this.dtpbd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpbd.Location = new System.Drawing.Point(913, 140);
            this.dtpbd.Name = "dtpbd";
            this.dtpbd.Size = new System.Drawing.Size(200, 22);
            this.dtpbd.TabIndex = 4;
            this.dtpbd.Value = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            // 
            // dtpkt
            // 
            this.dtpkt.CustomFormat = "dd/MM/yyyy";
            this.dtpkt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkt.Location = new System.Drawing.Point(913, 186);
            this.dtpkt.Name = "dtpkt";
            this.dtpkt.Size = new System.Drawing.Size(200, 22);
            this.dtpkt.TabIndex = 5;
            this.dtpkt.Value = new System.DateTime(2020, 6, 28, 0, 0, 0, 0);
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(913, 230);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(200, 22);
            this.txttien.TabIndex = 6;
            // 
            // txtmahv
            // 
            this.txtmahv.Location = new System.Drawing.Point(913, 101);
            this.txtmahv.Name = "txtmahv";
            this.txtmahv.Size = new System.Drawing.Size(200, 22);
            this.txtmahv.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Công nợ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày đăng kí:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(806, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày hết hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(806, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Số tiền(VND):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(806, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mã học viên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nhập vào mã học viên nếu bạn muốn tra cứu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(601, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Công nợ học viên theo lớp:";
            // 
            // button6
            // 
            this.button6.Image = global::QLHV.Properties.Resources.info__1_;
            this.button6.Location = new System.Drawing.Point(804, 296);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 23;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Image = global::QLHV.Properties.Resources.print_102332;
            this.button5.Location = new System.Drawing.Point(860, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 22;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Image = global::QLHV.Properties.Resources.list;
            this.button2.Location = new System.Drawing.Point(1081, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Image = global::QLHV.Properties.Resources.trash_can_115312;
            this.button4.Location = new System.Drawing.Point(1025, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::QLHV.Properties.Resources.Write_editnote_writ_9515;
            this.button3.Location = new System.Drawing.Point(969, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::QLHV.Properties.Resources.add;
            this.btnthem.Location = new System.Drawing.Point(913, 296);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(50, 50);
            this.btnthem.TabIndex = 7;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QLHV.Properties.Resources._1486504837_descending_filter_filtering_tool_funnel_sort_81363;
            this.button1.Location = new System.Drawing.Point(731, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 45);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formcongno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1146, 534);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmahv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.dtpkt);
            this.Controls.Add(this.dtpbd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbblop);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvcongno);
            this.Name = "Formcongno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công nợ học viên";
            this.Load += new System.EventHandler(this.Formcongno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcongno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcongno;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpbd;
        private System.Windows.Forms.DateTimePicker dtpkt;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtmahv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}