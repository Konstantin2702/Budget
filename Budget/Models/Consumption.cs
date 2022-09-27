
using System.ComponentModel.DataAnnotations;

namespace Budget.Models
{
    public enum Categories:int
    {
        Food,
        Transport,
        Entertainment,
        Services,
        Education
    }

    public class Consumption
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public double Cost { get; set; }

        [Required]
        public Categories Category { get; set; }

        [Required]
        public string Purchase { get; set; }
        
    }
}
