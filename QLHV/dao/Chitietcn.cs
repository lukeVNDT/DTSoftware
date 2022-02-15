using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dao
{
    class Chitietcn
    {
        private static Chitietcn instance;

        public static Chitietcn Instance { get { if (instance == null) instance = new Chitietcn(); return Chitietcn.instance; } private set { Chitietcn.instance = value; } }
        private Chitietcn() { }

        public bool insertctcn(string ten, float tien, int mahv)
        {
            string qr = string.Format("insert into chitietcn(tenloaithu,sotien,mahv) values (N'{0}',{1},{2})", ten, tien, mahv);
            int rs = DataProvider.Instance.ExecuteNonQuery(qr);

            return rs > 0;
        }
        public bool deletectcn(int id)
        {
            string query = string.Format("delete chitietcn where id = {0}", id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
        public bool updatectcn(string tenloaithu, float tien, int id)
        {
            string query = string.Format("update dbo.chitietcn set tenloaithu = N'{0}', sotien = {1} where id = {2}", tenloaithu,tien,id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);

            return rs > 0;
        }
    }
}
