using Market.DAL.Models;
using Market.DAL.Repository.Base;

namespace Market.DAL.Repository
{
    internal class TransactionRepository : Repository<Transaction, int>
    {
        public TransactionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
