using Market.DAL.Models;

namespace market.Api.ApiModel.Response
{
    public class TransactionApiResponse : IApiResponse
    {
        public int Id { get ; set ; }
        public CustomerApiResponse Customers { get; set; }
        public ProductApiResponse Products { get; set; }
        public int Amount { get; set; }
        public string Addres { get; set; }
    }
}
