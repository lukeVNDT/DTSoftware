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
    public partial class Formchitietcn : Form
    {
        public static string mahv2;
        public static string tien;
        public static string quyen2;
        public Formchitietcn()
        {
            InitializeComponent();
            loadchitietcn();
            sumtien();
            txtmahv.Text = mahv2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mahv = Convert.ToInt32(txtmahv.Text);
            float tien1 = float.Parse(txttien.Text);
            float tongtien = float.Parse(txttong.Text);
            string thu = txtloaithu.Text;
            float cvt = float.Parse(tien);
            if (tien1<=cvt&&tongtien+tien1<=cvt)
            {
                dao.Chitietcn.Instance.insertctcn(thu, tien1, mahv);
                MessageBox.Show("Đã thêm chi tiết công nợ thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadchitietcn();
                sumtien();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Số tiền vượt quá mức cho phép","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void loadchitietcn()
        {
            string qr = string.Format("select a.id as [Mã],a.tenloaithu as [Tên loại thu],a.sotien as [Số tiền],a.mahv as [Mã học viên] from chitietcn a,congno b where a.mahv=b.mahv and a.mahv='" + mahv2 + "'");
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvchitiet.DataSource = dataProvider.ExecuteQuery(qr);
            bidingctcn();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            //int ma = Convert.ToInt32(txtid.Text);
            //float tien1 = float.Parse(txttien.Text);
            //float tongtien = float.Parse(txttong.Text);
            //string thu = txtloaithu.Text;
            //float cvt = float.Parse(tien);
            //if (tongtien<cvt)
            //{
            //    MessageBox.Show("Số tiền chưa đủ");
            //}
            //else
            //{
            //    Formcongno formcongno = new Formcongno();
            //    this.Hide();
            //    formcongno.ShowDialog();
            //    this.Close();
            //}
            
        }
        private void sumtien()
        {
            int count = dgvchitiet.Rows.Count;
            float tongtien = 0;
            for (int i = 0; i < count - 1; i++)
                tongtien += float.Parse(dgvchitiet.Rows[i].Cells["Số tiền"].Value.ToString());
            txttong.Text = tongtien.ToString();
        }
        private void bidingctcn()
        {
            //txtmahv.DataBindings.Clear();
            //txtmahv.DataBindings.Add(new Binding("text", dgvchitiet.DataSource, "Mã học viên", true, DataSourceUpdateMode.Never));
            txtid.DataBindings.Clear();
            txtid.DataBindings.Add(new Binding("text", dgvchitiet.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txtloaithu.DataBindings.Clear();
            txtloaithu.DataBindings.Add(new Binding("text", dgvchitiet.DataSource, "Tên loại thu", true, DataSourceUpdateMode.Never));
            txttien.DataBindings.Clear();
            txttien.DataBindings.Add(new Binding("text", dgvchitiet.DataSource, "Số tiền", true, DataSourceUpdateMode.Never));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            if (dao.Chitietcn.Instance.deletectcn(id))
            {
                MessageBox.Show("Đã xóa chi tiết công nợ thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadchitietcn();
                sumtien();
            }
            else
            {
                MessageBox.Show("Xóa chi tiết công nợ thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtid.Text);
            float tien1 = float.Parse(txttien.Text);
            float tongtien = float.Parse(txttong.Text);
            string thu = txtloaithu.Text;
            float cvt = float.Parse(tien);
            if(tien1 <= cvt)
            {
                dao.Chitietcn.Instance.updatectcn(thu, tien1, ma);

                //MessageBox.Show("done");
                loadchitietcn();
                sumtien();
                if (tongtien < cvt)
                {
                    MessageBox.Show("Đã đủ rồi");
                }
                else
                {
                    
                }
                
               
            }
            else
            {
                MessageBox.Show("Failed");
            }


        }

        private void Formchitietcn_Load(object sender, EventArgs e)
        {
            if (quyen2 == "học viên")
            {
                button3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;

            }
        }

        private void Formchitietcn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formcongno formcongno = new Formcongno();
            this.Hide();
            formcongno.ShowDialog();
            this.Close();
        }
    }
}
