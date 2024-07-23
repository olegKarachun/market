using Market.DAL.Models.Base;
using System.Transactions;


namespace Market.DAL.Models
{
    public class Customer : Entity<int>
    {
        public Customer() : base(default)
        { }
        public Customer(int id, string Email, string Name) : base(id)
        {
            this.Email = Email;
            this.Name = Name;
        }

        public string Email { get; set; }
        public string Name { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
