using Market.DAL.Models;
using Market.DAL.Repository.Base;

namespace Market.DAL.Repository
{
    public class CustomerRepository : Repository<Customer, int>
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
        }
    }
}
