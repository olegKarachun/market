using AutoMapper;
using market.Api;
using market.Api.ApiModel;
using market.Api.ApiModel.Request;
using Market.BLL.Models;
using Market.DAL.Models;

namespace market.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<CustomerBusiness, Customer>().ReverseMap();
            CreateMap<CustomerApiResponse, CustomerBusiness>().ReverseMap();
            CreateMap<ProductApiResponse, ProductBusiness>().ReverseMap();
            CreateMap<ProductBusiness, Product>().ReverseMap();
            CreateMap<ProductApiRequest, ProductBusiness>().ReverseMap();



        }
    }
}
