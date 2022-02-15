using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dao
{
    class lop
    {
        private static lop instance;

        public static lop Instance { get { if (instance == null) instance = new lop(); return lop.instance; } private set { lop.instance = value; } }
        private lop() { }

        public List<dto.lop> laydslop()
        {
            List<dto.lop> lops = new List<dto.lop>();
            string query = "select * from lop";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                dto.lop dslop = new dto.lop(item);
               lops.Add(dslop);
            }
            return lops;

        }
        public bool Insertlop(string tenlop)
        {
            string query = string.Format("insert into dbo.lop(tenlop) values (N'{0}')", tenlop);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool updatelop(string tenlop, int malop)
        {
            string query = string.Format("update dbo.lop set tenlop = N'{0}' where idlop = {1}", tenlop,malop);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool deletelop(int malop)
        {
            string query = string.Format("delete from dbo.lop where idlop = {0}", malop);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
    }
}
