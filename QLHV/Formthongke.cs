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
    public partial class Formthongke : Form
    {
        public static string sodihoc;
        public static string songhihoc;
        public Formthongke()
        {
            InitializeComponent();
            txtcomat.Text = sodihoc;
            txtvang.Text = songhihoc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formdiemdanh2 formdiemdanh2 = new Formdiemdanh2();
            this.Hide();
            formdiemdanh2.ShowDialog();
            this.Close();
        }

        private void Formthongke_Load(object sender, EventArgs e)
        {

        }

        private void Formthongke_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Formthongke_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formdiemdanh2 formdiemdanh2 = new Formdiemdanh2();
            this.Hide();
            formdiemdanh2.ShowDialog();
            this.Close();
        }
    }
}
