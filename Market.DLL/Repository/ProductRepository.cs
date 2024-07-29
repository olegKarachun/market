using Market.DAL.Models;
using Market.DAL.Repository.Base;

namespace Market.DAL.Repository
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
