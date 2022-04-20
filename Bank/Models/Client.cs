using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public int AddressID { get;set; }
        public ICollection<BankAccount> BankAccounts { get; set; }
      
    }
}
