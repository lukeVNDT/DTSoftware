

using Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHV
{
    public partial class fqlhv : Form
    {
        public static string idlop;
        public static string role;
        public static string mahv;
        Classkn cn = new Classkn();
        private dto.taikhoan login;
        public static DateTime ngaykt;

        public dto.taikhoan Login
        {
            get { return login; }
            set { login = value; }
        }
        public fqlhv()
        {
            InitializeComponent();
            showtt();
            loadcbblop(cbblop);
            dtpdob.Value = DateTime.Now;
            gt();
            
        }
        DataSet result;

        private void fqlhv_Load(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            if (mahv == mahv)
            {
                string qr = "select mahv as [Mã học viên], b.tenlop as [Tên lớp], hovaten as [Họ và tên],gioitinh as [Giới tính],dob as [Ngày sinh], diachi as [Địa chỉ], sdt as [Số điện thoại] from dbo.thongtin a,dbo.lop b where a.idlop = b.idlop and a.mahv ='" + mahv + "'";
                dao.DataProvider dataProvider = new dao.DataProvider();
                dgvthongtin.DataSource = dataProvider.ExecuteQuery(qr);
                dgvthongtin.Columns[1].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
                bidingtt();
            }
            if (mahv=="1700669"||ngaykt==null)
            {
                
                string qr = "select mahv as [Mã học viên], b.tenlop as [Tên lớp], hovaten as [Họ và tên],gioitinh as [Giới tính],dob as [Ngày sinh], diachi as [Địa chỉ], sdt as [Số điện thoại] from dbo.thongtin a,dbo.lop b where a.idlop = b.idlop and a.mahv ='" + mahv + "'";
                dao.DataProvider dataProvider = new dao.DataProvider();
                dgvthongtin.DataSource = dataProvider.ExecuteQuery(qr);
                dgvthongtin.Columns[1].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
                bidingtt();
            }
            else if (ngaykt<current)
            {
                MessageBox.Show("Bạn chưa đóng học phí của tháng này, xin vui lòng liên hệ phòng tài chính để thanh toán và mở khóa tài khoản.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                fdangnhap fdangnhap = new fdangnhap();
                this.Hide();
                fdangnhap.ShowDialog();
                this.Close();
            }
            if (role == "học viên")
            {
                button1.Enabled = false;
                quảnLíHọcViênToolStripMenuItem.Enabled = false;
                btncapnhat.Enabled = false;
                btnthem.Enabled = true;
                btnxoa.Enabled = false;
                btnthem.Enabled = false;
                button2.Enabled = false;
                button1.Enabled = false;
                btnin.Enabled = false;
            }
            
            
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ftaikhoan ftk = new Ftaikhoan();
            this.Hide();
            ftk.ShowDialog();
            this.Close();
        }

        private void quảnLíHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                int mahv = Convert.ToInt32(txtmahocvien.Text);
                string hvt = txttenhv.Text;
                int idlop = (cbblop.SelectedItem as dto.lop).ID;
                string dob = dtpdob.Value.ToString();
                int sdt = Convert.ToInt32(txtsdt.Text);
                string diachi = txtdiachi.Text;
                string gt = cbbgt.Text;
                if (dao.thongtin.Instance.Inserttt(hvt,gt, dob,diachi, sdt, mahv, idlop))
                {
                    MessageBox.Show("Thêm thông tin học viên thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                showtt();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi! Hãy chắc chắn rằng mỗi thông tin học viên chỉ thuộc một mã học viên và hãy kiểm tra để chắc chắn rằng tài khoản của học viên đó đã được thêm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Ftaikhoan f = new Ftaikhoan();
            f.login = Login; 
        }
        private void showtt()
        {
            string qr = "exec alltt";
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvthongtin.DataSource = dataProvider.ExecuteQuery(qr);
            dgvthongtin.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            bidingtt();
        }
        private void loadcbblop(ComboBox cb)
        {
            cbblop.DataSource = dao.lop.Instance.laydslop();
            cbblop.DisplayMember = "Name";
            cbblop2.DataSource = dao.lop.Instance.laydslop();
            cbblop2.DisplayMember = "Name";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int mahv = Convert.ToInt32(txtmahocvien.Text);
            //try
            //{
            DialogResult rs = MessageBox.Show("Việc xóa sẽ khiến mọi thông tin khác liên quan đến học viên cũng bị xóa theo, bạn chắc chắn chứ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (rs==DialogResult.Yes)
                {
                    dao.thongtin.Instance.deletett(mahv);
                    MessageBox.Show("Xóa thông tin học viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showtt();
                }
                
                else
                {
                    showtt();
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Xóa thông tin học viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            int mahv = Convert.ToInt32(txtmahocvien.Text);
            string hvt = txttenhv.Text;
            int idlop = (cbblop.SelectedItem as dto.lop).ID;
            string dob = dtpdob.Value.ToString();
            int sdt = Convert.ToInt32(txtsdt.Text);
            string diachi = txtdiachi.Text;
            string gt = cbbgt.Text;
            try
            {
                
                if (dao.thongtin.Instance.updatett(hvt,gt, dob, diachi, sdt, idlop, mahv))
                {
                    MessageBox.Show("Sửa thông tin học viên thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
              
            }
            catch
            {
                if (string.IsNullOrEmpty(txtmahocvien.Text))
                {
                    MessageBox.Show("kiểm tra lại dữ liệu của mã học viên");
                }
                else 
                { 
                    MessageBox.Show("Sửa thông tin học viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlop f = new Formlop();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void điểmDanhHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formdiemdanh fd = new Formdiemdanh();
            this.Hide();
            fd.ShowDialog();
            this.Close();
        }
        private void bidingtt()
        {
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add(new Binding("text", dgvthongtin.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            txtmahocvien.DataBindings.Clear();
            txtmahocvien.DataBindings.Add(new Binding("text", dgvthongtin.DataSource, "Mã học viên", true, DataSourceUpdateMode.Never));
            txtsdt.DataBindings.Clear();
            txtsdt.DataBindings.Add(new Binding("text", dgvthongtin.DataSource, "Số điện thoại", true, DataSourceUpdateMode.Never));
            txttenhv.DataBindings.Clear();
            txttenhv.DataBindings.Add(new Binding("text", dgvthongtin.DataSource, "Họ và tên", true, DataSourceUpdateMode.Never));
            cbblop.DataBindings.Clear();
            cbblop.DataBindings.Add(new Binding("text", dgvthongtin.DataSource, "Tên lớp", true, DataSourceUpdateMode.Never));
            dtpdob.DataBindings.Clear();
            dtpdob.DataBindings.Add(new Binding("text", dgvthongtin.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never));
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            fdangnhap fdangnhap = new fdangnhap();
            this.Hide();
            fdangnhap.ShowDialog();
            this.Close();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            Formrp formrp = new Formrp();
            //this.Hide();
            formrp.ShowDialog();
            //this.Close();
            //idlop = (cbblop2.SelectedItem as dto.lop).Name;
           //Formrp.lop = (cbblop2.SelectedItem as dto.lop).Name;
        }
        void loadttbylop(int idlop)
        {
            dgvthongtin.DataSource = dao.thongtin.Instance.thongtinbylop(idlop);
        }
        private void tk(string mahv)
        {
            string qr = string.Format("select hovaten as [Họ và tên],dob as [Ngày sinh], diachi as [Địa chỉ], sdt as [Số điện thoại], mahv as [Mã học viên], b.tenlop as [Tên lớp] from dbo.thongtin a,dbo.lop b where a.idlop=b.idlop and a.mahv like N'%{0}%'", mahv);
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvthongtin.DataSource = dataProvider.ExecuteQuery(qr);
            //bidingtt();
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            
            loadttbylop((cbblop2.SelectedItem as dto.lop).ID);
            bidingtt();
            //dgvthongtin.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void gt()
        {
            List<string> gt = new List<string>()
            {
                "Nam",
                "Nữ"
            };
            cbbgt.DataSource = gt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tk(Convert.ToInt32(textBox5.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            tk(textBox5.Text);
        }

        private void dgvthongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter="Excel Workbook|*.xls", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    reader.IsFirstRowAsColumnNames = true;
                    result = reader.AsDataSet();
                    cbbsheet.Items.Clear();
                    foreach(DataTable dt in result.Tables)
                    {
                        cbbsheet.Items.Add(dt.TableName);
                        reader.Close();
                    }
                }
                dgvthongtin.Columns[4].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            }
        }

        private void cbbsheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvthongtin.DataSource = result.Tables[cbbsheet.SelectedIndex];
            bidingtt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ib ib = new ib();
            this.Hide();
            ib.ShowDialog();
            this.Close();
        }

        private void côngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formcongno formcongno = new Formcongno();
            
            formcongno.ShowDialog();
            
        }

        private void tKBHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlichhoc formlichhoc = new Formlichhoc();
            this.Hide();
            formlichhoc.ShowDialog();
            this.Close();
        }

        private void thốngKêSốBuổiĐãHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlocttđ formlocttđ = new Formlocttđ();
            this.Hide();
            formlocttđ.ShowDialog();
            this.Close();
        }
    }
}
