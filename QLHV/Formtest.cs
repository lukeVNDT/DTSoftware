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
    public partial class Formtest : Form
    {
        public static string role;
        Classkn cn = new Classkn();
        public Formtest()
        {
            InitializeComponent();
        }

        private void Formtest_Load(object sender, EventArgs e)
        {
            if (fdangnhap.infor == "học viên")
            {
                btntest.Enabled = false;
            }
        }
    }
}
