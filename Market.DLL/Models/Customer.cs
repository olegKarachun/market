using Market.DAL.Models.Base;
using System.Transactions;


namespace Market.DAL.Models
{
    public class Customer : Entity
    {
        public Customer()
        { }
        public Customer(int id, string Email, string Name) 
        {
            this.Id = id;
            this.Email = Email;
            this.Name = Name;
        }

        public string Email { get; set; }
        public string Name { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
