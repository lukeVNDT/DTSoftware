namespace QLHV
{
    partial class Formthongke
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcomat = new System.Windows.Forms.TextBox();
            this.txtvang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Có mặt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vắng:";
            // 
            // txtcomat
            // 
            this.txtcomat.Location = new System.Drawing.Point(136, 61);
            this.txtcomat.Name = "txtcomat";
            this.txtcomat.Size = new System.Drawing.Size(151, 22);
            this.txtcomat.TabIndex = 2;
            // 
            // txtvang
            // 
            this.txtvang.Location = new System.Drawing.Point(136, 103);
            this.txtvang.Name = "txtvang";
            this.txtvang.Size = new System.Drawing.Size(151, 22);
            this.txtvang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sĩ số";
            // 
            // Formthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(355, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtvang);
            this.Controls.Add(this.txtcomat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formthongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sĩ số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formthongke_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formthongke_FormClosed);
            this.Load += new System.EventHandler(this.Formthongke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcomat;
        private System.Windows.Forms.TextBox txtvang;
        private System.Windows.Forms.Label label3;
    }
}