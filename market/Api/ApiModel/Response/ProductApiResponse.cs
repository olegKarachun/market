namespace market.Api.ApiModel
{
    public class ProductApiResponse : IApiResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Photo { get; set; }
        public string Amount { get; set; }
    }
}
