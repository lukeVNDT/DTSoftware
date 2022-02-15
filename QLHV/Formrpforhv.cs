using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHV
{
    public partial class Formrpforhv : Form
    {
        public static string mahv;
        public Formrpforhv()
        {
            InitializeComponent();
            txtmahv.Text = mahv;
        }

        private void Formrpforhv_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mahv1 = Convert.ToInt32(txtmahv.Text);
            // TODO: This line of code loads data into the 'qlhvDataSet3.congnobymahv' table. You can move, or remove it, as needed.
            this.congnobymahvTableAdapter.Fill(this.qlhvDataSet3.congnobymahv,mahv1);

            this.reportViewer1.RefreshReport();
        }
    }
}
