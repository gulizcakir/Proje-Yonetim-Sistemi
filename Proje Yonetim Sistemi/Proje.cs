using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_Yonetim_Sistemi
{
    public class Proje
    {
        public string ProjeAdi { get; set; }
        public string StratejikEtki { get; set; }
        public string ProjeNo { get; set; }
        public Calisan ProjeYurutucusu { get; set; }
        public string Amac { get; set; }
        public string ProblemTanimi { get; set; }
        public string Kapsam { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime ProjeBaslangici { get; set; }
        public DateTime ProjeBitisi { get; set; }      
        public DateTime TahminiBitis { get; set; }
        public Durum Durum { get; set; }
        public decimal ParasalGetiri { get; set; }
        public string ParasalGetiriTipi { get; set; }
        public List<Calisan> ProjeEkip { get; set; }
        public List<string> ProjeDokumanlari { get; set; }
        public ProjeTipi ProjeTipi { get; set; }
        public List<KilometreTasi> KilometreTaslari { get; set; }
    }

    public enum Durum
    {
        Red,
        OnayBekliyor,
        DevamEdiyor,
        Tamamlandi,
        // Diğer durumlar eklenebilir
    }

    public enum GetiriTipi
    {
        Gunluk,
        Aylik,
        Yillik
    }

    public enum ProjeTipi
    {
        Yurtdışı,
        Tübitak,
        Kobi,     
    }

    public class KilometreTasi
    {
        public string Ad { get; set; }
        public List<Gorev> Gorevler { get; set; }
        public KilometreTasi()
        {
            Gorevler = new List<Gorev>();
        }
    }

    public class Gorev
    {
        public string Ad { get; set; }
            
    }
}
