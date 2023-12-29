using System.ComponentModel.DataAnnotations;

namespace HastaneSistemi.Models
{
    public class Poliklinik
    {
        [Key]
        public int PoliklinikID { get; set; }
        public string? PoliklinikAd { get; set; }
        public IList<Doktor> Doktors { get; set; }

    }
}
