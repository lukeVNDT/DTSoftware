using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dao
{
    class thongtin
    {
        private static thongtin instance;

        public static thongtin Instance
        {
            get { if (instance == null) instance = new thongtin(); return thongtin.instance; }
            private set { thongtin.instance = value; }
        }
        private thongtin() { }

        public bool Inserttt(string hvt,string gt, string dob, string diachi, int sdt, int mahv, int lopid)
        {
            string query = string.Format("insert into dbo.thongtin(hovaten,dob,gioitinh,diachi,sdt,mahv,idlop) values (N'{0}','{1}',N'{2}',N'{3}','{4}','{5}','{6}')", hvt,dob,gt,diachi,sdt,mahv,lopid);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool deletett(int id)
        {
            string query = string.Format("delete thongtin where mahv = {0}", id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool updatett(string hvt,string gt, string dob, string diachi, int sdt, int lopid, int mahv)
        {
            string query = string.Format("update dbo.thongtin set hovaten = N'{0}', dob = N'{1}',gioitinh=N'{2}',diachi = N'{3}',sdt = {4},idlop = {5} where mahv = {6}", hvt,dob,gt,diachi,sdt,lopid,mahv);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public DataTable thongtinbylop(int idlop)
        {
            return DataProvider.Instance.ExecuteQuery("exec allttbylop @idlop", new object[] { idlop });
        }
        public DataTable thongtinnguoidungnhap(int mahv)
        {
            return DataProvider.Instance.ExecuteQuery("select hovaten,dob, diachi, sdt, mahv as [Mã học viên], b.tenlop from dbo.thongtin a,dbo.lop b where a.idlop = b.idlop and a.mahv", new object[] { mahv });
        }
        
    }
}
