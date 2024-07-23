using Market.DAL.Models.Base;
using System.Transactions;

namespace Market.DAL.Models
{
    public class Product : Entity<int>
    {
        public Product() :base(default)
        { }
        public Product(int id, string name, string description, int price, string photo, int amount, List<Transaction> transactions): base(id)
        {
            Name = name;
            Description = description;
            Price = price;
            Photo = photo;
            Amount = amount;
            Transactions = transactions;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public int Amount { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
