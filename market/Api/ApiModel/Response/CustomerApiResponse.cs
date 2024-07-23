using Market.DAL.Models;
using System.Transactions;

namespace market.Api
{
    public class CustomerApiResponse : IApiResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

    }
}
