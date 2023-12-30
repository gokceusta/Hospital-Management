using HastaneSistemi.Controllers;
using Microsoft.EntityFrameworkCore;

namespace HastaneSistemi.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-25KPGPPO\\SQLEXPRESS;database = HastaneSistemi; integrated security=true;TrustServerCertificate=true;");
        }
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Hasta> Hastas { get; set; }

        public DbSet<Poliklinik> Polikliniks { get; set; }

        public DbSet<Randevu> Randevus { get; set; }

        public DbSet<Hesap> Hesaps { get; set; }

        public DbSet<Kayit>Kayits { get; set; }

    }
}
