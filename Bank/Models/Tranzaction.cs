using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Tranzaction
    {
        [Key]
        public int TranzactionID { get; set; }
        public string Operation { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public int BankID { get; set; }
        public BankAccount Bank { get; set; }
    }
}
