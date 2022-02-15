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
    public partial class Formdiemdanh : Form
    {
        public static DataGridView DataGridView;
        public static DateTime ngaykt;
        public Formdiemdanh()
        {
            InitializeComponent();
            //showdiemdanh();
            loadcbblop(cbblop);
            loadcbblop(cbblop2);
            DataGridView = dgvdiemdanh;
            //DateTime ngay = dtpdiemdanh.Value;
            //ngay = DateTime.Now;
            listtt();
            
            
        }
        private void showdiemdanh()
        {
            string qr = "exec alltt";
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvdiemdanh.DataSource = dataProvider.ExecuteQuery(qr);
            bidingdiemdanh();
        }
        private void loadcbblop(ComboBox cbb) 
        {
            cbb.DataSource = dao.lop.Instance.laydslop();
            cbb.DisplayMember = "Name";
            cbblop2.DataSource = dao.lop.Instance.laydslop();
            cbblop2.DisplayMember = "Name";

        }
       

        private void btnthem_Click(object sender, EventArgs e)
        {
            int mahv2 = int.Parse(txtmahv.Text);
            ngaykt = Convert.ToDateTime(dao.DataProvider.Instance.ExecuteScalar("select ngaykt from congno where mahv = '" + mahv2 + "'"));
            string tt = cbbtrangthai.Text;
            DateTime curentday = DateTime.Now;
            curentday.ToString("yyyy:MM:dd HH:mm");
            int mahv = Convert.ToInt32(txtmahv.Text);
            int idlop = (cbblop.SelectedItem as dto.lop).ID;
            DateTime ngay = dtpdiemdanh.Value;
            ngay.ToString("yyyy:MM:dd HH:mm");
            //if(dao.diemdanh.Instance.Inserdd(ngay, mahv, idlop))
            //{

            //MessageBox.Show("Điểm danh học viên thất bại, lỗi phát sinh do không có tên học viên này trong danh sách học viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
            int rs = DateTime.Compare(ngay.Date, curentday.Date);
            if (rs < 0)
            {
                MessageBox.Show("Không thể điểm danh cho ngày hôm qua!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(rs>0)
            {
                MessageBox.Show("Không thể diểm danh cho ngày kế tiếp!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (ngaykt < curentday)
            {
                MessageBox.Show("Không thể điểm danh học viên này, học viên chưa thanh toán công nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dao.diemdanh.Instance.Inserdd(ngay, mahv, idlop,tt);
                MessageBox.Show("Đã điểm danh thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            
            /*if (ngay > curentday)
            {
                MessageBox.Show("Bạn không thể điểm danh những ngày kế tiếp được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            

            //showdiemdanh();

            
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            fqlhv fql = new fqlhv();
            this.Hide();
            fql.ShowDialog();
            this.Close();
        }
        private void loadtg() {
            string mahv = txtmahv.Text;
            ngaykt =Formdiemdanh2.ngay2= Convert.ToDateTime(dao.DataProvider.Instance.ExecuteScalar("select ngaykt from congno where mahv = '"+mahv+"'"));
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            /*int mahv = Convert.ToInt32(txtmahv.Text);
            int idlop = (cbblop.SelectedItem as dto.lop).ID;
            //string tt = cbbtrangthai.SelectedItem.ToString();
            DateTime ngay = dtpdiemdanh.Value;
            try
            {
                if (dao.diemdanh.Instance.updatediemdanh(mahv, idlop, ngay))
                {
                    MessageBox.Show("Đã sửa thông tin điểm danh thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                showdiemdanh();
            }
            catch
            {
                MessageBox.Show("Sửa thông tin điểm danh thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        }
        private void bidingdiemdanh()
        {
            txtmahv.DataBindings.Clear();
            txtmahv.DataBindings.Add(new Binding("text",dgvdiemdanh.DataSource,"Mã học viên",true,DataSourceUpdateMode.Never));
            cbblop.DataBindings.Clear();
            cbblop.DataBindings.Add(new Binding("text", dgvdiemdanh.DataSource, "Tên lớp", true, DataSourceUpdateMode.Never));
            //cbbtrangthai.DataBindings.Clear();
            //cbbtrangthai.DataBindings.Add(new Binding("text", dgvdiemdanh.DataSource, "Trạng thái", true, DataSourceUpdateMode.Never));
            //dtpdiemdanh.DataBindings.Clear();
            //dtpdiemdanh.DataBindings.Add(new Binding("text", dgvdiemdanh.DataSource, "Ngày", true, DataSourceUpdateMode.Never));
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            
        }

        private void Formdiemdanh_Load(object sender, EventArgs e)
        {

        }
        private void loadttbylop(int idlop)
        {
            dgvdiemdanh.DataSource = dao.thongtin.Instance.thongtinbylop(idlop);
            dgvdiemdanh.Columns[1].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadttbylop((cbblop2.SelectedItem as dto.lop).ID);
            bidingdiemdanh();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formdiemdanh2 formdiemdanh = new Formdiemdanh2();
            this.Hide();
            formdiemdanh.ShowDialog();
            this.Close();
        }

        private void dtpdiemdanh_ValueChanged(object sender, EventArgs e)
        {
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
        }
    }
}
