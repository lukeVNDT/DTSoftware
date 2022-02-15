using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dto
{
    public class taikhoan
    {
        public taikhoan(int id,string mk,int roleid, string namerole)
        {
            this.ID = id;
            this.MK = mk;
            this.RoleID = roleid;
            this.Namerole = namerole;
        }
        public taikhoan(DataRow row)
        {
            this.ID = (int)row["mahv"];
            this.MK = row["matkhau"].ToString();
            this.RoleID = (int)row["roleid"];
            this.Namerole = row["tenrole"].ToString();
        }

        private int id;
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string mk;

        public string MK
        {
            get { return mk; }
            set { mk = value; }
        }
        private int roleid;

        int RoleID
        {
            get { return roleid; }
            set { roleid = value; }
        }
        private string namerole;
        public string Namerole
        {
            get { return namerole; }
            set { namerole = value; }
        }
    }
}
