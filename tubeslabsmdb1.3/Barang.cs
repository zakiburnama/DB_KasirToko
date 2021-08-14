using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tubeslabsmdb1._3
{
    class Barang
    {
        public string ID { get; set; }
        public string NAMA { get; set; }
        public string HARGA { get; set; }
        public string STOK { get; set; }

        public Barang(string iD, string nAMA, string hARGA, string sTOK)
        {
            ID = iD;
            NAMA = nAMA;
            HARGA = hARGA;
            STOK = sTOK;
        }
    }
}
