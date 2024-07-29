using AutoMapper;
using Market.BLL.Models;
using Market.BLL.Service.Base;
using Market.DAL.Models;
using Market.DAL.Repository;
using Market.DAL.Repository.Base;


namespace Market.BLL.Service
{
    public class TransactionService : GenericService<TransactionBusiness, Transaction>
    {
        public TransactionService(TransactionRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
