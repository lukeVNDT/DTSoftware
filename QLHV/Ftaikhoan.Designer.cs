namespace QLHV
{
    partial class Ftaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ftaikhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmhv = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtrole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvtk = new System.Windows.Forms.DataGridView();
            this.btntrove = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtmhv
            // 
            this.txtmhv.Location = new System.Drawing.Point(119, 33);
            this.txtmhv.Name = "txtmhv";
            this.txtmhv.Size = new System.Drawing.Size(163, 22);
            this.txtmhv.TabIndex = 2;
            this.txtmhv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(121, 90);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(161, 22);
            this.txtmk.TabIndex = 3;
            this.txtmk.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtrole
            // 
            this.txtrole.FormattingEnabled = true;
            this.txtrole.Location = new System.Drawing.Point(119, 148);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(163, 24);
            this.txtrole.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quyền:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvtk
            // 
            this.dgvtk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtk.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvtk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtk.Location = new System.Drawing.Point(310, 31);
            this.dgvtk.Name = "dgvtk";
            this.dgvtk.RowHeadersWidth = 51;
            this.dgvtk.RowTemplate.Height = 24;
            this.dgvtk.Size = new System.Drawing.Size(389, 404);
            this.dgvtk.TabIndex = 10;
            // 
            // btntrove
            // 
            this.btntrove.Image = global::QLHV.Properties.Resources._001_23;
            this.btntrove.Location = new System.Drawing.Point(231, 213);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(51, 35);
            this.btntrove.TabIndex = 9;
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::QLHV.Properties.Resources._001_49;
            this.btndelete.Location = new System.Drawing.Point(174, 213);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(51, 35);
            this.btndelete.TabIndex = 8;
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnadd
            // 
            this.btnadd.Image = global::QLHV.Properties.Resources._001_01;
            this.btnadd.Location = new System.Drawing.Point(60, 213);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(51, 35);
            this.btnadd.TabIndex = 7;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QLHV.Properties.Resources.Write_editnote_writ_9515;
            this.button1.Location = new System.Drawing.Point(117, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 35);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Ftaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvtk);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtmhv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ftaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài khoản";
            this.Load += new System.EventHandler(this.Ftaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmhv;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.ComboBox txtrole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.DataGridView dgvtk;
        private System.Windows.Forms.Button button1;
    }
}