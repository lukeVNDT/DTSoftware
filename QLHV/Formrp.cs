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
    public partial class Formrp : Form
    {
        public Formrp()
        {
            InitializeComponent();
            loadcbblop(comboBox1);
        }

        private void Formrp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlhvDataSet.allttforrp5' table. You can move, or remove it, as needed.
            //this.allttforrp5TableAdapter.Fill(this.qlhvDataSet.allttforrp5);
            // TODO: This line of code loads data into the 'qlhvDataSet7.allttforrp4' table. You can move, or remove it, as needed.
            //this.allttforrp4TableAdapter.Fill(this.qlhvDataSet7.allttforrp4);
            // TODO: This line of code loads data into the 'qlhvDataSet6.allttforrp4' table. You can move, or remove it, as needed.
            //this.allttforrp4TableAdapter.Fill(this.qlhvDataSet7.allttforrp4);

        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            fqlhv fqlhv = new fqlhv();
            this.Hide();
            fqlhv.ShowDialog();
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lop = (comboBox1.SelectedItem as dto.lop).Name;
            // TODO: This line of code loads data into the 'qlhvDataSet3.allttforrp2' table. You can move, or remove it, as needed.
            this.allttforrp5TableAdapter.Fill(this.qlhvDataSet.allttforrp5,lop);

            // TODO: This line of code loads data into the 'qlhvDataSet2.allttforrp' table. You can move, or remove it, as needed.
            //this.allttforrpTableAdapter.Fill(this.qlhvDataSet2.allttforrp,fqlhv.idlop);
            this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }
        private void loadcbblop(ComboBox cb)
        {
            cb.DataSource = dao.lop.Instance.laydslop();
            cb.DisplayMember = "Name";
        }

        private void reportViewer1_ReportExport(object sender, Microsoft.Reporting.WinForms.ReportExportEventArgs e)
        {
           
        }

        private void reportViewer1_RenderingComplete(object sender, Microsoft.Reporting.WinForms.RenderingCompleteEventArgs e)
        {
            
        }

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
           
        }
    }
}
