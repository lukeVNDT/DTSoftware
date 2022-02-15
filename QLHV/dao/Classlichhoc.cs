using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dao
{
    class Classlichhoc
    {
        private static Classlichhoc instance;

        public static Classlichhoc Instance { get { if (instance == null) instance = new Classlichhoc(); return Classlichhoc.instance; } private set { Classlichhoc.instance = value; } }
        private Classlichhoc() { }

        public static int cao = 100;
        public static int rong = 100;

        public List<dto.Classlichhoc> loadlich()
        {
            List<dto.Classlichhoc> classlichhocs = new List<dto.Classlichhoc>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("exec lich");
            foreach (DataRow item in dataTable.Rows)
            {
                dto.Classlichhoc classlichhoc = new dto.Classlichhoc(item);
                classlichhocs.Add(classlichhoc);
            }
            return classlichhocs;
        }
        public bool insertlich(string thu, string ngay, string phong,string tt, int idlop)
        {
            string qr = string.Format("insert into lichhoc(thu,ngay,phong,trangthai,idlop) values (N'{0}','{1}',N'{2}',N'{3}',{4})", thu,ngay,phong,tt,idlop);
            int rs = DataProvider.Instance.ExecuteNonQuery(qr);

            return rs > 0;
        }
    }
}
