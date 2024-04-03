using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Proje_Yonetim_Sistemi
{
    [XmlRoot("Kullanici")]
    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public Kullanici(string kullaniciAdi, string sifre)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
        }

        public Kullanici() { }
    }
}
