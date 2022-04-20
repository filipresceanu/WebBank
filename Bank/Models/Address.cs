using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        public string Country { get; set; }
        public string City { get; set; }

        public string Street { get; set; }
        public int Number { get; set; }

        public ICollection<Client> Clients { get; set; }
    }
}
