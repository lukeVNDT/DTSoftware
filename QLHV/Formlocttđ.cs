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
    
    public partial class Formlocttđ : Form
    {
        public static string mahv;
        public static string sobuoihoc;
        public static string sobuoivang;
        public static string thang;
        public Formlocttđ()
        {
            InitializeComponent();
            //listtt();
            listthang();
            txtmahv.Text = mahv;
        }
        //private void listtt()
        //{
        //    List<string> trangthai;
        //    trangthai = new List<string>()
        //    {
        //        "Có mặt",
        //        "Vắng mặt"
        //    };
        //    cbbtrangthai.DataSource = trangthai;
        //}
        private void listthang()
        {
            List<string> thang;
            thang = new List<string>()
            {
                "01",
                "02",
                "03",
                "04",
                "05",
                "06",
                "07",
                "08",
                "09",
                "10",
                "11",
                "12"
            };
            cbbthang.DataSource = thang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mahv = Convert.ToInt32(txtmahv.Text);
            string thang = cbbthang.Text;
            sobuoihoc=Convert.ToString(dao.DataProvider.Instance.ExecuteScalar("select count(*) as [Số buổi đã học trong tháng] from diemdanh where trangthai = N'Có mặt' and MONTH(ngay)='" + thang + "' and mahv='" + mahv + "'"));
            sobuoivang = Convert.ToString(dao.DataProvider.Instance.ExecuteScalar("select count(*) as [Số buổi đã học trong tháng] from diemdanh where trangthai = N'Vắng mặt' and MONTH(ngay)='" + thang + "' and mahv='" + mahv + "'"));
            thang = Convert.ToString(dao.DataProvider.Instance.ExecuteScalar("select MONTH(ngay) from diemdanh where MONTH(ngay)='"+thang+"'"));
            MessageBox.Show("Số buổi đã học trong tháng "+thang+" là : "+sobuoihoc+" và số buổi đã vắng là "+sobuoivang+"","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
