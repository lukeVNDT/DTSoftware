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
    public partial class Formrpdiemdanh : Form
    {
        public Formrpdiemdanh()
        {
            InitializeComponent();
            loadcbblop(cbblop);
        }

        private void Formrpdiemdanh_Load(object sender, EventArgs e)
        {
            
        }
        private void loadcbblop(ComboBox cbb)
        {
            cbb.DataSource = dao.lop.Instance.laydslop();
            cbb.DisplayMember = "Name";
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            int lop = (cbblop.SelectedItem as dto.lop).ID;
            DateTime n = dtpngay.Value;
            n.ToString("yyyy/MM/dd");
            // TODO: This line of code loads data into the 'qlhvDataSet.allttforrp5' table. You can move, or remove it, as needed.
            this.lopvatgforrpTableAdapter.Fill(this.qlhvDataSet1.lopvatgforrp,lop,n);

            this.reportViewer1.RefreshReport();
        }
    }
}
