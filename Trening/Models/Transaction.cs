namespace Trening.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Customer Customers { get; set; }
        public Product Products { get; set; }
        public int Amount { get; set; }
        public string Addres { get; set; }
    }
}
