using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class AccountType
    {
        [Key]
        public int AccountTypeId { get; set; }
        public string Name { get; set; }
        public float RetreatPercentage { get; set; }
        public float DepositPercentage { get; set; }
        public float RetreatFixSume { get; set; }
        public float DepositFixSume { get; set; }
        ICollection<BankAccount>BankAccounts { get; set; }
        
    }
}
