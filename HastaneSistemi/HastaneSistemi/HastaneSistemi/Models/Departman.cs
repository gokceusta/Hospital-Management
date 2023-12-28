namespace HastaneSistemi.Models
{
    public class Departman
    {
        public string Name { get; set; }
        public int PoliklinikNo { get; set; }
        public Doktor doktor { get; set; }  


    }
}
