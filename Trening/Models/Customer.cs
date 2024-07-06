using Trening.Models.Interfaces;

namespace Trening.Models
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
