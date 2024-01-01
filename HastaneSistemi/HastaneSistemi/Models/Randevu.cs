using System.ComponentModel.DataAnnotations;

namespace HastaneSistemi.Models
{
    public class Randevu 
    { 

    [Key]
    public int RandevuID { get; set; }
    public string? RandevuGun { get; set; }
    public char RandevuSaat { get; set; }
    public int DoktorID { get; set; }
    public Doktor Doktor { get; set; }
    public int HastaID { get; set; }
    public Hasta Hasta { get; set; }
 
    }
}
