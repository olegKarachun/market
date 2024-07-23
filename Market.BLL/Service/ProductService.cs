using AutoMapper;
using Market.BLL.Models;
using Market.BLL.Service.Base;
using Market.DAL.Models;
using Market.DAL.Repository;
using Market.DAL.Repository.Base;

namespace Market.BLL.Service
{
    public class ProductService : GenericService<ProductBusiness, int, Product, int>
    {
        public ProductService(ProductRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        protected override int MapToEntityId(int businessId)
        {
            return businessId;
        }
    }
}
