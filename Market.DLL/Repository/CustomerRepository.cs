using Market.DAL.Models;
using Market.DAL.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Market.DAL.Repository
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {
            
        }

        public async Task<Customer> GetCustomerByEmailAsync(string email)
        {
            return await context.Set<Customer>().FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
