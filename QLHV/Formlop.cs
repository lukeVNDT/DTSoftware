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
    public partial class Formlop : Form
    {
        public Formlop()
        {
            InitializeComponent();
            showlop();
        }
        private void showlop()
        {
            string qr = "select idlop as [Mã lớp], tenlop as [Tên lớp] from lop";
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvlop.DataSource = dataProvider.ExecuteQuery(qr);
            bidinglop();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tenlop = txttenlop.Text;
            if (dao.lop.Instance.Insertlop(tenlop))
            {
                MessageBox.Show("Thêm lớp thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            showlop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenlop = txttenlop.Text;
            int malop = Convert.ToInt32(txtmalop.Text);
            if (dao.lop.Instance.updatelop(tenlop,malop))
            {
                MessageBox.Show("Sửa tên lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            showlop();
        }
        private void bidinglop()
        {
            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add(new Binding("text", dgvlop.DataSource, "Mã lớp", true, DataSourceUpdateMode.Never));
            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add(new Binding("text", dgvlop.DataSource, "Tên lớp", true, DataSourceUpdateMode.Never));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fqlhv f = new fqlhv();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            int malop = Convert.ToInt32(txtmalop.Text);
            try
            {
                DialogResult result = MessageBox.Show("Việc xóa lớp sẽ khiến tất cả mọi thông tin của học viên đó đều bị xóa theo, bạn chắc chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    dao.lop.Instance.deletelop(malop);
                    MessageBox.Show("Đã xóa lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    showlop();
                }
                else
                {
                    showlop();
                }
        }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc xóa lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //fqlhv fqlhv = new fqlhv();
            //    //this.Hide();
            //    //fqlhv.ShowDialog();
            //    //this.Close();
                showlop();
            }
        }
    }
}
