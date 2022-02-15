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
    public partial class Formdiemdanh2 : Form
    {
        public static string diihoc;
        public static string nghiihoc;
        public static DateTime ngay2;
        public Formdiemdanh2()
        {
            InitializeComponent();
            showdiemdanh();
            loadcbblop(cbblop3);
            loadcbblop(comboBox2);
            bidingdiemdanh();
            listtt();
           
            
        }

        private void Formdiemdanh2_Load(object sender, EventArgs e)
        {

        }
        
        private void showdiemdanh()
        {
            string qr = "exec ttdiemdanh";
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvdd2.DataSource = dataProvider.ExecuteQuery(qr);
            dgvdd2.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            dgvdd2.Columns[4].DefaultCellStyle.Format = "dd'/'MM'/'yyyy HH:mm:ss";
            bidingdiemdanh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formdiemdanh formdiemdanh = new Formdiemdanh();
            this.Hide();
            formdiemdanh.ShowDialog();
            this.Close();
        }
        private void loadcbblop(ComboBox cbb)
        {
            cbb.DataSource = dao.lop.Instance.laydslop();
            cbb.DisplayMember = "Name";
        }
        private void showdsdiemdanhbylopanđay(int idlop1,string d)
        {
            dgvdd2.DataSource = dao.diemdanh.Instance.thongtinbylopandngay(idlop1,d);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showdiemdanhbyloptg();
            bidingdiemdanh();
            //showdsdiemdanhbylopanđay(l,n);
        }
      

        private void dtpngayloc_ValueChanged(object sender, EventArgs e)
        {

        }
        private void bidingdiemdanh()
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add(new Binding("text", dgvdd2.DataSource, "Mã học viên", true, DataSourceUpdateMode.Never));
            comboBox2.DataBindings.Clear();
            comboBox2.DataBindings.Add(new Binding("text", dgvdd2.DataSource, "Tên lớp", true, DataSourceUpdateMode.Never));
            //comboBox3.DataBindings.Clear();
            //comboBox3.DataBindings.Add(new Binding("text", dgvdd2.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add(new Binding("text", dgvdd2.DataSource, "Ngày điểm danh", true, DataSourceUpdateMode.Never));
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int mahv = Convert.ToInt32(textBox1.Text);
            int idlop = (comboBox2.SelectedItem as dto.lop).ID;
            DateTime ngay = dateTimePicker1.Value;
            try
            {
                if (dao.diemdanh.Instance.updatediemdanh(mahv, idlop, ngay))
                {
                    MessageBox.Show("Đã sửa thông tin điểm danh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                showdiemdanh();
            }
            catch
            {
                MessageBox.Show("Sửa thông tin điểm danh thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm:ss");
        
            //y
            //{
                if (dao.diemdanh.Instance.deletedd(ngay))
                {
                    MessageBox.Show("Đã xóa thông tin điểm danh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                showdiemdanh();
            //}
            //catch
            //{
              //  MessageBox.Show("Xóa thông tin điểm danh thất bại! xin kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgvdd2_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void showdiemdanhbyloptg()
        {
            string tt = cbbtrangthai2.SelectedItem.ToString();
            int l = (cbblop3.SelectedItem as dto.lop).ID;
            string n = dtpngayloc.Value.ToString("yyyy/MM/dd");
            string qr = "select a.mahv as [Mã học viên],c.tenlop as [Tên lớp], b.hovaten as [Họ và tên],b.dob as [Ngày sinh],a.ngay as [Ngày điểm danh], a.trangthai as [Trạng thái] from diemdanh a, thongtin b, lop c where a.mahv = b.mahv and a.idlop = c.idlop and a.idlop='"+l+"' and CAST(a.ngay as DATE)='"+n+"' and a.trangthai = N'"+tt+"'";
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvdd2.DataSource = dataProvider.ExecuteQuery(qr);
            dgvdd2.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvdd2.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formrpdiemdanh formrpdiemdanh = new Formrpdiemdanh();
            this.Hide();
            formrpdiemdanh.ShowDialog();
            this.Close();
        }
        private void listtt()
        {
            List<string> trangthai;
            trangthai = new List<string>()
            {
                "Có mặt",
                "Vắng mặt"
            };
            cbbtrangthai.DataSource = trangthai;
            cbbtrangthai2.DataSource = trangthai;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void laydihoc()
        {
            int lop = (cbblop3.SelectedItem as dto.lop).ID;
            string tt = cbbtrangthai2.Text;
            string n = dtpngayloc.Value.ToString("yyyy/MM/dd");
            diihoc  = Convert.ToString(dao.DataProvider.Instance.ExecuteScalar("select count(*) as [số đi học] from diemdanh a, thongtin b, lop c where a.mahv = b.mahv and a.idlop = c.idlop and a.idlop='"+lop+"' and CAST(a.ngay as DATE)='"+n+"' and a.trangthai=N'Có mặt'"));
        }
        private void laynghihoc()
        {
            int lop = (cbblop3.SelectedItem as dto.lop).ID;
            string tt = cbbtrangthai2.Text;
            string n = dtpngayloc.Value.ToString("yyyy/MM/dd");
            nghiihoc  = Convert.ToString(dao.DataProvider.Instance.ExecuteScalar("select count(*) as [số đi học] from diemdanh a, thongtin b, lop c where a.mahv = b.mahv and a.idlop = c.idlop and a.idlop='" + lop + "' and CAST(a.ngay as DATE)='" + n + "' and a.trangthai=N'Vắng mặt'"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            laydihoc();
            laynghihoc();
            MessageBox.Show("Có mặt: "+diihoc+" vắng: "+nghiihoc+"","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //laydihoc();
            //laynghihoc();
            //Formthongke formthongke = new Formthongke();
            //this.Hide();
            //formthongke.ShowDialog();
            //this.Close();
        }
    }
}
