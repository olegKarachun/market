using Market.DAL.Models.Base;

namespace Market.DAL.Models
{
    public class Transaction : Entity
    {
        public Transaction()
        { }
        public Transaction(int id, Customer customers, Product products, int amount, string addres)
        {
            Id = id;
            Customers = customers;
            Products = products;
            Amount = amount;
            Addres = addres;
        }

        public int Id { get; set; }
        public int Amount { get; set; }
        public string Addres { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }


        public Customer Customers { get; set; }
        public Product Products { get; set; }
    }
}
