namespace market.Api.ApiModel.Request
{
    public class TransactionApiRequest
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public string Addres { get; set; }
    }
}
