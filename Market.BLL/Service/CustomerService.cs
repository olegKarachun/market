using AutoMapper;
using Market.BLL.Models;
using Market.BLL.Service.Base;
using Market.DAL.Models;
using Market.DAL.Repository;

namespace Market.BLL.Service
{
    public class CustomerService : GenericService<CustomerBusiness, int, Customer, int>
    {
        public CustomerService(CustomerRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        protected override int MapToEntityId(int businessId)
        {
            return businessId;
        }
    }
}
