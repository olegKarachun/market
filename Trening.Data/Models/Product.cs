using Trening.Models.Interfaces;

namespace Trening.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Photo { get; set; }
        public string Amount { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
