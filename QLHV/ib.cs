using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHV
{
    public partial class ib : Form
    {
        public ib()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                WebClient webClient = new WebClient();
                Stream st = webClient.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=PGwEAbM0RvKlNCM_38em2w==&to={0}&content={1}",textBox1.Text,richTextBox1.Text));
                StreamReader reader = new StreamReader(st);
                string rs = reader.ReadToEnd();
                MessageBox.Show(rs,"Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"tb",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
