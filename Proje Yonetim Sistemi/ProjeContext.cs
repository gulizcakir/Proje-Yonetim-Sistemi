using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proje_Yonetim_Sistemi
{
    public class ProjeContext : DbContext
    {
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-9TA5199T\\SQLEXPRESS;Database=ProjeYonetimSistemi;Integrated Security=True;User Id=guliz;\r\n");
        }
    }
}
