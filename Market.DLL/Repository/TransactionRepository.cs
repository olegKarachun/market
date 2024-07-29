using Market.DAL.Models;
using Market.DAL.Models.Base;
using Market.DAL.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace Market.DAL.Repository
{
    public class TransactionRepository : Repository<Transaction>
    {
        public TransactionRepository(AppDbContext context) : base(context)
        {
        
        }
        public override async Task<List<Transaction>> Get()
        {
            return await context.Set<Transaction>().Include(x=>x.Products).Include(x => x.Customers).ToListAsync();
        }

        public override async Task<Transaction> GetById(int id)
        {
            return await context.Set<Transaction>().Include(x => x.Products).Include(x => x.Customers).FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
