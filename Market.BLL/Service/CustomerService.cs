using AutoMapper;
using Market.BLL.Models;
using Market.BLL.Service.Base;
using Market.DAL.Models;
using Market.DAL.Repository;

namespace Market.BLL.Service
{
    public class CustomerService : GenericService<CustomerBusiness, Customer>
    {
        private readonly CustomerRepository customerRepository;
        public CustomerService(CustomerRepository repository, IMapper mapper) : base(repository, mapper)
        {
            customerRepository=repository;
        }

        public async Task<Customer> GetCustomerbyEmailAsync(string email)
        {
            return await customerRepository.GetCustomerByEmailAsync(email);
        }
    }
}
