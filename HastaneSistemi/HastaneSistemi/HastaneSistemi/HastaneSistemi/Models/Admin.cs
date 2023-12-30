using System.ComponentModel.DataAnnotations;

namespace HastaneSistemi.Models
{
    public class Admin
    {
        [Key]
        public string AdminID { get; set; }
        public string AdminMail { get; set; }
        public string AdminSifre { get; set; }
    }
}
