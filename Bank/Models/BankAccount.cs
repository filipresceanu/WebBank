using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class BankAccount
    {
        [Key]
        public int BankAccountID { get; set; }
        public int PIN { get; set; }
        public double Sold { get; set; }
        public string IBAN { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }
        public AccountType Type { get; set; }
        public int AccountTypeID { get; set; }

        public Client Client { get; set; }
        public int ClientID { get; set; }
        ICollection<Tranzaction> Transactions { get; set; }
    }
}
