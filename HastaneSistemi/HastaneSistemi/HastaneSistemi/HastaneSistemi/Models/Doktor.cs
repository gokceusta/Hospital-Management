using System.ComponentModel.DataAnnotations;

namespace HastaneSistemi.Models
{
    public class Doktor
    {
        [Key]
        public int DoktorID { get; set; }
        public string? DoktorAd { get; set; }
        public string? DoktorSoyad { get; set; }
        public int PoliklinikID { get; set; }
        public Poliklinik Poliklinik { get; set; }
        public IList<Randevu> Randevus { get; set; }
    }
}
