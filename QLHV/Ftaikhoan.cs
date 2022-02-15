using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHV
{
    public partial class Ftaikhoan : Form
    {
        Classkn cn = new Classkn();
        public static string hienthi;
        public SqlCommand cmdd;
        public static string role;
        public dto.taikhoan login;
        public static string mahv;
        public Ftaikhoan()
        {
            InitializeComponent();
            //hienthitk();
            loadcb(txtrole);
            //bidingtk();
            //showtk();
        }
        private void Ftaikhoan_Load(object sender, EventArgs e)
        {
            showtk();
        }

        
        public void loadcb(ComboBox cb)
        {
            cb.DataSource = dao.role.Instance.laydsrole();
            cb.DisplayMember = "Name";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
 
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int id = Int32.Parse(txtmhv.Text);
            string mk = txtmk.Text;
            int roleid = (txtrole.SelectedItem as dto.role).ID;
            int id = Convert.ToInt32(txtmhv.Text);
            try
            {
                if (txtrole.Text == "admin")
                {
                    MessageBox.Show("Chỉ nên tồn tại duy nhất 1 admin trong hệ thống! Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dao.taikhoan.Instance.Inserttk(mk, roleid))
                {
                    MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                showtk();
            }
            catch
            {
                MessageBox.Show("Bạn nên thêm thông tin học viên trước khi tạo tài khoản");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int role = (txtrole.SelectedItem as dto.role).ID;
            int id = Int32.Parse(txtmhv.Text);
            
            if(dao.taikhoan.Instance.deletetk(id))
            {
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (mahv == mahv)
            {

                MessageBox.Show("Oops! Tài khoản này không thể bị xóa khỏi hệ thống vì bạn đang là người sử dụng tài khoản này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            showtk();
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            fqlhv ftk = new fqlhv();
            this.Hide();
            ftk.ShowDialog();
            this.Close();
        }
        private void bidingtk()
        {
            txtmhv.DataBindings.Clear();
            txtmhv.DataBindings.Add(new Binding("text", dgvtk.DataSource, "Mã học viên", true, DataSourceUpdateMode.Never));
            txtmk.DataBindings.Clear();
            txtmk.DataBindings.Add(new Binding("text", dgvtk.DataSource, "Mật khẩu", true, DataSourceUpdateMode.Never));
            txtrole.DataBindings.Clear();
            txtrole.DataBindings.Add(new Binding("text", dgvtk.DataSource, "Tên quyền", true, DataSourceUpdateMode.Never));
        }
        private void showtk()
        {
            string qr = "exec alltk";
            dao.DataProvider dataProvider = new dao.DataProvider();
            dgvtk.DataSource = dataProvider.ExecuteQuery(qr);
            bidingtk();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mk = txtmk.Text;
            int roleid = (txtrole.SelectedItem as dto.role).ID;
            int id = Convert.ToInt32(txtmhv.Text);
            try
            {
                if (txtrole.Text == "admin")
                {
                    MessageBox.Show("Hệ thống nên tồn tại 1 admin duy nhất!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if(dao.taikhoan.Instance.updatetk(id, mk, roleid))
                {
                    MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                showtk();
            }
            catch
            {
                MessageBox.Show("Sửa tài khoản thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
