using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dto
{
    class role
    {
        public role(int id, string name, int stt)
        {
            this.ID = id;
            this.Name = name;
      
   
        }

        public role(DataRow row)
        {
            this.ID = (int)row["roleid"];
            this.Name = row["tenrole"].ToString();
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
