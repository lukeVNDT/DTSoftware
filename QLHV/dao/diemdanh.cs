using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dao
{
    class diemdanh
    {
        private static diemdanh instance;

        public static diemdanh Instance { get { if (instance == null) instance = new diemdanh(); return diemdanh.instance; } private set { diemdanh.instance = value; } }
        private diemdanh() { }

        public bool Inserdd(DateTime ngay,int mahv, int lopid,string tt)
        {
            string query = string.Format("insert into dbo.diemdanh(ngay,mahv,idlop,trangthai) values (N'{0}',{1},{2},N'{3}')", ngay,mahv, lopid,tt);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool updatediemdanh(int mahv,int lop, DateTime ngay)
        {
            string query = string.Format("update dbo.diemdanh set ngay = N'{0}',mahv = {1},idlop = {2} where mahv = {2}", ngay,mahv,lop);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool deletedd(string ngay)
        {
            string query = string.Format("delete diemdanh where ngay = '{0}'", ngay);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public DataTable thongtinbylopandngay(int idlop,string d)
        {
            return DataProvider.Instance.ExecuteQuery("exec lopvatg @idlop, @tg", new object[] {idlop, d});
        }
    }
}
