
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
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Cost { get; set; }
        
        public Categories Category { get; set; }

        public string Purchase { get; set; }
        
    }
}
