namespace QLHV
{
    partial class Formdiemdanh2
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
            this.dgvdd2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbblop3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dtpngayloc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbtrangthai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbtrangthai2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdd2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvdd2
            // 
            this.dgvdd2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdd2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvdd2.BackgroundColor = System.Drawing.Color.White;
            this.dgvdd2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdd2.Location = new System.Drawing.Point(22, 97);
            this.dgvdd2.Name = "dgvdd2";
            this.dgvdd2.RowHeadersWidth = 51;
            this.dgvdd2.RowTemplate.Height = 24;
            this.dgvdd2.Size = new System.Drawing.Size(921, 308);
            this.dgvdd2.TabIndex = 0;
            this.dgvdd2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvdd2_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách điểm danh";
            // 
            // cbblop3
            // 
            this.cbblop3.FormattingEnabled = true;
            this.cbblop3.Location = new System.Drawing.Point(22, 61);
            this.cbblop3.Name = "cbblop3";
            this.cbblop3.Size = new System.Drawing.Size(121, 24);
            this.cbblop3.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 416);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã học viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 495);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 24, 16, 38, 24, 0);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(385, 457);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // dtpngayloc
            // 
            this.dtpngayloc.CustomFormat = "dd/MM/yyyy";
            this.dtpngayloc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngayloc.Location = new System.Drawing.Point(195, 61);
            this.dtpngayloc.Name = "dtpngayloc";
            this.dtpngayloc.Size = new System.Drawing.Size(146, 22);
            this.dtpngayloc.TabIndex = 14;
            this.dtpngayloc.ValueChanged += new System.EventHandler(this.dtpngayloc_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lớp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ngày điểm danh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Trạng thái:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbbtrangthai
            // 
            this.cbbtrangthai.FormattingEnabled = true;
            this.cbbtrangthai.Location = new System.Drawing.Point(385, 536);
            this.cbbtrangthai.Name = "cbbtrangthai";
            this.cbbtrangthai.Size = new System.Drawing.Size(218, 24);
            this.cbbtrangthai.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Trạng thái:";
            // 
            // cbbtrangthai2
            // 
            this.cbbtrangthai2.FormattingEnabled = true;
            this.cbbtrangthai2.Location = new System.Drawing.Point(367, 61);
            this.cbbtrangthai2.Name = "cbbtrangthai2";
            this.cbbtrangthai2.Size = new System.Drawing.Size(124, 24);
            this.cbbtrangthai2.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Image = global::QLHV.Properties.Resources.school__1_;
            this.button2.Location = new System.Drawing.Point(554, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 37);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QLHV.Properties.Resources.print_102332;
            this.button1.Location = new System.Drawing.Point(385, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnthongke
            // 
            this.btnthongke.Image = global::QLHV.Properties.Resources.filter_icon__1_;
            this.btnthongke.Location = new System.Drawing.Point(497, 54);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(49, 37);
            this.btnthongke.TabIndex = 18;
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::QLHV.Properties.Resources._001_23;
            this.button3.Location = new System.Drawing.Point(553, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::QLHV.Properties.Resources._001_49;
            this.btnxoa.Location = new System.Drawing.Point(497, 571);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(50, 50);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::QLHV.Properties.Resources.Write_editnote_writ_9515;
            this.btnsua.Location = new System.Drawing.Point(441, 571);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(50, 50);
            this.btnsua.TabIndex = 15;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // Formdiemdanh2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(970, 649);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbbtrangthai2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbtrangthai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.dtpngayloc);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbblop3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdd2);
            this.Name = "Formdiemdanh2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách điểm danh";
            this.Load += new System.EventHandler(this.Formdiemdanh2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdd2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdd2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbblop3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dtpngayloc;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbtrangthai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbtrangthai2;
        private System.Windows.Forms.Button button2;
    }
}