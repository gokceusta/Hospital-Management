namespace HastaneSistemi.Models
{
    public class Randevu
    {
        public int Id { get; set; }
        public string Gun { get; set; }
        public string Saat { get; set; }
        public Departman Departman { get; set; }
        public Doktor Doktor { get; set; }
        public Hasta Hasta { get; set; }
    }
}
