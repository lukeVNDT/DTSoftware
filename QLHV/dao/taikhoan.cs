using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHV.dao
{
    class taikhoan
    {
        private static taikhoan instance;

        public static taikhoan Instance
        {
            get { if (instance == null) instance = new taikhoan(); return taikhoan.instance; }
            private set { taikhoan.instance = value; }
        }
        private taikhoan() { }

        public bool Inserttk(string mk, int roleid)
        {
            string query = string.Format("insert into dbo.taikhoan(matkhau,roleid) values (N'{0}','{1}')",mk, roleid);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool deletetk(int id)
        {
            string query = string.Format("delete taikhoan where mahv = {0}", id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public List<dto.taikhoan> GetListUser()
        {
            List<dto.taikhoan> list = new List<dto.taikhoan>();

            string query = "exec alltk";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                dto.taikhoan taikhoan = new dto.taikhoan(item);
                list.Add(taikhoan);
            }

            return list;

        }
        public bool updatetk(int mahv, string mk,int roleid)
        {
            string query = string.Format("update dbo.taikhoan set matkhau = N'{0}', roleid = {1} where mahv = {2}",mk,roleid,mahv);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
    }
}
