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
    public partial class Formrpcongno1 : Form
    {
        public Formrpcongno1()
        {
            InitializeComponent();
            loadcbblop(cbblop);
        }

        private void Formcongno1_Load(object sender, EventArgs e)
        {
            
        }
        private void loadcbblop(ComboBox cb)
        {
            cb.DataSource = dao.lop.Instance.laydslop();
            cb.DisplayMember = "Name";
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            int lop = (cbblop.SelectedItem as dto.lop).ID;
            // TODO: This line of code loads data into the 'qlhvDataSet2.congnobylop' table. You can move, or remove it, as needed.
            this.congnobylopTableAdapter.Fill(this.qlhvDataSet2.congnobylop,lop);

            this.reportViewer1.RefreshReport();
        }
        
    }
}
