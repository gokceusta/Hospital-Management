using System.ComponentModel.DataAnnotations;

namespace HastaneSistemi.Models
{
    public class Kayit
    {
        [Key]
        public int HesapID { get; set; }
        public string? HesapAd { get; set; }
        public string? HesapSoyad { get; set; }
        public string? HesapMail { get; set; }
        public string? HesapSifre { get; set; }

    }
}
