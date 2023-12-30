using System.ComponentModel.DataAnnotations;

namespace HastaneSistemi.Models
{
    public class Hesap
    {
        [Key]
        public int HesapID { get; set; }
        public string? HesapMail { get; set; }
        public string? HesapSifre {  get; set; }
        
    }
}
