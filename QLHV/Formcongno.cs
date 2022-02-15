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
    public partial class Formcongno : Form
    {
        public static string ngaykt;
        public static string mahv;
        public static string mahv2;
        public static string tien;
        public static string quyen;
        public Formcongno()
        {
            InitializeComponent();
            showcongno();
            //layngaykt();
            loadcbblop(cbblop);
            //tongtien();
        }
        Classkn cn = new Classkn();
        private void showcongno()
        {
            string qr = "select a.mahv as [Mã học viên],b.hovaten as [Họ và tên],c.tenlop as [Tên lớp], ngaybd as [Ngày đăng kí], ngaykt as [Ngày hết hạn], sotien as [Số tiền] from congno a, thongtin b, lop c where a.mahv=b.mahv and b.idlop=c.idlop";
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvcongno.DataSource = dataProvider.ExecuteQuery(qr);
            bidingcongno();
            layngaykt();
        }
        private void showtt()
        {
            string qr = "select mahv as [Mã học viên], b.tenlop as [Tên lớp], hovaten as [Họ và tên],gioitinh as [Giới tính],dob as [Ngày sinh], diachi as [Địa chỉ], sdt as [Số điện thoại] from dbo.thongtin a,dbo.lop b where a.idlop = b.idlop";
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvcongno.DataSource = dataProvider.ExecuteQuery(qr);
            bidingmahv();
            dgvcongno.Columns[4].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }
        private void bidingmahv()
        {
            txtmahv.DataBindings.Clear();
            txtmahv.DataBindings.Add(new Binding("text", dgvcongno.DataSource, "Mã học viên", true, DataSourceUpdateMode.Never));
        }
        private void layngaykt()
        {
            ngaykt = "select ngaykt from congno where mahv = '" + txtmahv.Text + "'";
            cn.XemDL(ngaykt);
        }
        private void bidingcongno()
        {
            txtmahv.DataBindings.Clear();
            txtmahv.DataBindings.Add(new Binding("text", dgvcongno.DataSource, "Mã học viên", true, DataSourceUpdateMode.Never));
            dtpbd.DataBindings.Clear();
            dtpbd.DataBindings.Add(new Binding("text", dgvcongno.DataSource, "Ngày đăng kí", true, DataSourceUpdateMode.Never));
            dtpkt.DataBindings.Clear();
            dtpkt.DataBindings.Add(new Binding("text", dgvcongno.DataSource, "Ngày hết hạn", true, DataSourceUpdateMode.Never));
            txttien.DataBindings.Clear();
            txttien.DataBindings.Add(new Binding("text", dgvcongno.DataSource, "Số tiền", true, DataSourceUpdateMode.Never));
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int mahv = Convert.ToInt32(txtmahv.Text);
            float tien = float.Parse(txttien.Text);
            string ngaybd = dtpbd.Value.ToString("yyyy/MM/dd");
            string ngaykt = dtpkt.Value.ToString("yyyy/MM/dd");
            try
            {
                if (dao.congno.Instance.insertcn(ngaybd, ngaykt, tien, mahv))
                {
                    MessageBox.Show("Đã thêm công nợ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                showcongno();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc thêm công nợ, thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formcongno_Load(object sender, EventArgs e)
        {
            if (mahv == mahv)
            {
                string qr = "select a.mahv as [Mã học viên],b.hovaten as [Họ và tên],c.tenlop as [Tên lớp], ngaybd as [Ngày đăng kí], ngaykt as [Ngày hết hạn], sotien as [Số tiền] from congno a, thongtin b, lop c where a.mahv=b.mahv and b.idlop=c.idlop and a.mahv='"+mahv+"'";
                dao.DataProvider dataProvider = new dao.DataProvider();
                dgvcongno.DataSource = dataProvider.ExecuteQuery(qr);
                dgvcongno.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
                dgvcongno.Columns[4].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
                bidingcongno();
            }
            if (quyen == "học viên")
            {
                button3.Enabled = false;
                btnthem.Enabled = false;
                button4.Enabled = false;
                button2.Enabled = false;
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showtt();
            dgvcongno.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void loadcbblop(ComboBox cb)
        {
            cbblop.DataSource = dao.lop.Instance.laydslop();
            cbblop.DisplayMember = "Name";
        }
        void loadttbylop(int idlop)
        {
            dgvcongno.DataSource = dao.congno.Instance.thongtincongnobylop(idlop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadttbylop((cbblop.SelectedItem as dto.lop).ID);
            bidingcongno();
            dgvcongno.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvcongno.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void bidingtt()
        {
            txtmahv.DataBindings.Clear();
            txtmahv.DataBindings.Add(new Binding("text", dgvcongno.DataSource, "Mã học viên", true, DataSourceUpdateMode.Never));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            congno(txtsearch.Text);
        }
        private void congno(string mahv)
        {
            string qr = string.Format("select a.mahv as [Mã học viên], b.hovaten as [Họ và tên], c.tenlop as [Tên lớp], ngaybd as [Ngày đăng kí], ngaykt as [Ngày hết hạn], sotien as [Số tiền] from congno a, thongtin b, lop c where a.mahv = b.mahv and b.idlop = c.idlop and a.mahv like N'%{0}%'", mahv);
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvcongno.DataSource = dataProvider.ExecuteQuery(qr);
            //bidingtt();
        }
        
        //private void tongtien()
        //{
        //    int count = dgvcongno.Rows.Count;
        //    float tongtien = 0;
        //    for (int i = 0; i < count - 1; i++)
        //        tongtien += float.Parse(dgvcongno.Rows[i].Cells["Số tiền"].Value.ToString());
        //    txttong.Text = tongtien.ToString();
        //}
        private void button6_Click(object sender, EventArgs e)
        {
            //tongtien();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mahv = Convert.ToInt32(txtmahv.Text);
            float tien = float.Parse(txttien.Text);
            string ngaybd = dtpbd.Value.ToString("yyyy/MM/dd");
            string ngaykt = dtpkt.Value.ToString("yyyy/MM/dd");
            try
            {
                if (dao.congno.Instance.updatecn(ngaybd,ngaykt,tien,mahv))
                {
                    MessageBox.Show("Đã cập nhật công nợ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                showcongno();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc cập nhật công nợ, thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mahv = Convert.ToInt32(txtmahv.Text);
            try
            {
                if (dao.congno.Instance.deletecn(mahv))
                {
                    MessageBox.Show("Đã xóa công nợ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                showcongno();
            }
            catch
            {
                MessageBox.Show("Có lỗi trong lúc xóa công nợ, thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mahv == "1700669")
            {
                Formrpcongno1 formrpcongno1 = new Formrpcongno1();
                formrpcongno1.ShowDialog();
            }
            else
            {
                Formrpforhv formrpforhv = new Formrpforhv();
                formrpforhv.ShowDialog();
            }
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            laymhv();
            laysotien();
            Formchitietcn formchitietcn = new Formchitietcn();
            this.Hide();
            formchitietcn.ShowDialog();
            this.Close();
        }
        private void laymhv()
        {
            int mahv = Convert.ToInt32(txtmahv.Text);
            mahv2 = Formchitietcn.mahv2 = Convert.ToString(dao.DataProvider.Instance.ExecuteScalar("select mahv from congno where mahv ='" + mahv + "'"));
        }
        private void laysotien()
        {
            tien = Formchitietcn.tien = Convert.ToString(dao.DataProvider.Instance.ExecuteScalar("select sotien from congno where mahv='" + txtmahv.Text + "'"));
        }
    }
}
