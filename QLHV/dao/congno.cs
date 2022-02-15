using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dao
{
    class congno
    {
        private static congno instance;

        public static congno Instance { get { if (instance == null) instance = new congno(); return congno.instance; } private set { congno.instance = value; } }
        private congno() { }

        public bool insertcn(string ngaybd,string ngaykt,float tien,int mahv)
        {
            string qr = string.Format("insert into congno(ngaybd,ngaykt,sotien,mahv) values ('{0}','{1}',{2},{3})", ngaybd, ngaykt, tien, mahv);
            int rs = DataProvider.Instance.ExecuteNonQuery(qr);

            return rs > 0;
        }
        public DataTable thongtincongnobylop(int idlop)
        {
            return DataProvider.Instance.ExecuteQuery("exec allttcn @idlop", new object[] { idlop });
        }
        public bool updatecn(string ngaybd, string ngaykt, float tien, int mahv)
        {
            string query = string.Format("update dbo.congno set ngaybd = '{0}', ngaykt = '{1}',sotien={2} where mahv = {3}", ngaybd,ngaykt,tien, mahv);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool deletecn(int id)
        {
            string query = string.Format("delete congno where mahv = {0}", id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
    }
}
