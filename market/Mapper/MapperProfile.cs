using AutoMapper;
using market.Api;
using market.Api.ApiModel;
using market.Api.ApiModel.Request;
using market.Api.ApiModel.Response;
using Market.BLL.Models;
using Market.DAL.Models;

namespace market.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Customer mappings
            CreateMap<CustomerBusiness, Customer>().ReverseMap();
            CreateMap<CustomerApiResponse, CustomerBusiness>().ReverseMap();
            CreateMap<CustomerApiRequest, CustomerBusiness>().ReverseMap();

            // Product mappings
            CreateMap<ProductApiResponse, ProductBusiness>().ReverseMap();
            CreateMap<ProductApiRequest, ProductBusiness>().ReverseMap();
            CreateMap<ProductBusiness, Product>().ReverseMap();

            // Transaction mappings
            CreateMap<TransactionApiResponse, TransactionBusiness>().ReverseMap();
            CreateMap<TransactionApiRequest, TransactionBusiness>().ReverseMap();
            CreateMap<TransactionBusiness, Transaction>().ReverseMap();
        }
    }
}
