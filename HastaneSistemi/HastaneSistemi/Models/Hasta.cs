using System.ComponentModel.DataAnnotations;

namespace HastaneSistemi.Models
{
    public class Hasta
    {
        [Key]
        public int HastaID { get; set; }
        public string? HastAd { get; set; }
        public string? HastaSoyad { get; set; }
        public IList<Randevu> Randevus { get; set; }
    }
}
 