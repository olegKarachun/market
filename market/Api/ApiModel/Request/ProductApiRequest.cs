namespace market.Api.ApiModel.Request
{
    public class ProductApiRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public int Amount { get; set; }
        //public List<Transaction> Transactions { get; set; }
    }
}
