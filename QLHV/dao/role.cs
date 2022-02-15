using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dao
{
    class role
    {
        private static role instance;

        public static role Instance
        {
            get { if (instance == null) instance = new role(); return role.instance; }
            private set { role.instance = value; }
        }
        private role() { }
        public List<dto.role> laydsrole()
        {
            List<dto.role> list = new List<dto.role>();

            string query = "select * from quyen";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                dto.role dsrole = new dto.role(item);
                list.Add(dsrole);
            }

            return list;
        }
    }
}
