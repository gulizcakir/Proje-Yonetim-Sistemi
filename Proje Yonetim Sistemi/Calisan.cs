using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Yonetim_Sistemi
{
    public class Calisan
    {
        //[Key]
        public string calisanTc { get; set; }
        public string calsanAdi { get; set; }
        public string calsanCinsiyet { get; set; }
        public string calsanEgitimDurumu { get; set; }
        public string telefonNumarasi { get; set; }
        public byte[] Resim { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }

    }
}
