using Market.DAL.Models.Base;

namespace Market.DAL.Models
{
    public class Transaction : Entity<int>
    {
        public Transaction() : base(default)
        { }
        public Transaction(int id, Customer customers, Product products, int amount, string addres) : base(id)
        {
            Customers = customers;
            Products = products;
            Amount = amount;
            Addres = addres;
        }

        public int Id { get; set; }
        public Customer Customers { get; set; }
        public Product Products { get; set; }
        public int Amount { get; set; }
        public string Addres { get; set; }
    }
}
