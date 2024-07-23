using AutoMapper;
using Market.BLL.Models;
using Market.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerBusiness, Customer>().ReverseMap();
            CreateMap<TransactionBusiness, Customer>().ReverseMap();
            CreateMap<ProductBusiness, Product>().ReverseMap();
            CreateMap<ProductBusiness, Product>();

        }
    }
}
