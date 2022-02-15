using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHV.dto
{
    class Classlichhoc
    {
        public Classlichhoc(string thu, string ngay, string phong, string tt, int idlop)
        {
            this.Thu = thu;
            this.Ngay = ngay;
            this.Phong = phong;
            this.Trangthai = tt;
            this.Idlop = idlop;
        }
        public Classlichhoc(DataRow row)
        {
            this.Thu = row["thu"].ToString();
            this.Ngay = row["ngay"].ToString();
            this.Phong = row["phong"].ToString();
            //this.Trangthai = row["trangthai"].ToString();
            //this.Idlop = (int)row["idlop"];
        }
        private int ID;

        public int ID1 { get => ID; set => ID = value; }
        public string Thu { get => thu; set => thu = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string Phong { get => phong; set => phong = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Idlop { get => idlop; set => idlop = value; }

        private string thu;

        private string ngay;

        private string phong;

        private string trangthai;

        private int idlop;
    }
}
