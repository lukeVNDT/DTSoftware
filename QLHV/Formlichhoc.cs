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
    public partial class Formlichhoc : Form
    {
        public static Button btn;
        public Formlichhoc()
        {
            InitializeComponent();
            load();
            loadcbblop(cbblop);
            listthu();
            listtt();
            
        }
        public void load()
        {
           List<dto.Classlichhoc> table = dao.Classlichhoc.Instance.loadlich();
           foreach(dto.Classlichhoc item in table)
            {
                Button btn = new Button()
                {
                    Height = dao.Classlichhoc.cao,
                    Width = dao.Classlichhoc.rong
                };
                btn.Text = item.Thu + Environment.NewLine + item.Ngay + Environment.NewLine + item.Phong;
                switch (item.Thu)
                {
                    case "Thứ hai":
                        btn.BackColor = Color.Coral;
                        break;
                    case "Thứ ba":
                        btn.BackColor = Color.Coral;
                        break;
                    case "Thứ tư":
                        btn.BackColor = Color.Coral;
                        break;
                    case "Thứ năm":
                        btn.BackColor = Color.Coral;
                        break;
                    case "Thứ sáu":
                        btn.BackColor = Color.Coral;
                        break;
                }
                flppanel.Controls.Add(btn);

            }

        }
        private void bidinglich()
        {
            
        }
        private void loadcbblop(ComboBox cbb)
        {
            cbb.DataSource = dao.lop.Instance.laydslop();
            cbb.DisplayMember = "Name";
        }
        private void listtt()
        {
            List<string> trangthai;
            trangthai = new List<string>()
            {
                "Trong quá trình",
                "Đã kết thúc"
            };
            cbbtrangthai.DataSource = trangthai;
        }
        private void listthu()
        {
            List<string> thu;
            thu = new List<string>()
            {
                "Thứ hai",
                "Thứ ba",
                "Thứ tư",
                "Thứ năm",
                "Thứ sáu"
            };
            cbbthu.DataSource = thu;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string thu = cbbthu.Text;
            string ngay = dtpngay.Value.ToString("yyyy/MM/dd");
            string phong = txtphong.Text;
            string tt = cbbtrangthai.Text;
            int idlop = (cbblop.SelectedItem as dto.lop).ID;
            if (dao.Classlichhoc.Instance.insertlich(thu, ngay, phong, tt, idlop))
            {
                MessageBox.Show("Thêm lịch học thành công");
            }
            
            else
            {
                MessageBox.Show("failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
