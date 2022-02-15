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
    public partial class fdangnhap : Form
    {
        public static string infor;
        public static string mahv;
        public static DateTime ngaykt;
       
        public fdangnhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Classkn cn = new Classkn();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlhv;Integrated Security=True");
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = CommandType.Text;
            string mahv = txtmahv.Text.Trim();
            //Convert.ToInt32(mahv);
            string mk = txtmk.Text.Trim();
            string sql = "Select * from dbo.taikhoan where mahv ='" + mahv + "'"
                            + "and matkhau = '" + mk + "'";
            //cmd.Connection = conn;

            //conn.Open();
            //SqlDataReader rd = cmd.ExecuteReader();
            //try
            //{
                if (mahv != "" || mk != "")
                {
                    if (cn.XemDL(sql).Rows.Count != 0)
                    {
                        //SqlCommand cmd2 = new SqlCommand();
                        //cmd2.CommandType = CommandType.Text;
                        infor =  fqlhv.role =Formcongno.quyen =Formchitietcn.quyen2= cn.XemDL("select tenrole from dbo.taikhoan a, dbo.quyen b where b.roleid = a.roleid and mahv ='" + mahv + "'"
                                        + "and matkhau = '" + mk + "'").Rows[0][0].ToString().Trim();
                        mahv = fqlhv.mahv =Formlocttđ.mahv =Formrpforhv.mahv = Formcongno.mahv = Ftaikhoan.mahv = cn.XemDL("select mahv from dbo.taikhoan a where mahv ='" + mahv + "'"
                                        + "and matkhau = '" + mk + "'").Rows[0][0].ToString().Trim();
                    ngaykt = fqlhv.ngaykt = Convert.ToDateTime(dao.DataProvider.Instance.ExecuteScalar("select ngaykt from congno a, taikhoan b where a.mahv=b.mahv and b.mahv='"+mahv+"'"));
                    //rd = cmd2.ExecuteReader();
                    MessageBox.Show("đăng nhập thành công, quyền " + fqlhv.role, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fqlhv fql = new fqlhv();
                        this.Hide();
                        fql.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("failed", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            //}
            //catch
            //{
                //MessageBox.Show("error:" );
            //}

            }
            

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fdangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
