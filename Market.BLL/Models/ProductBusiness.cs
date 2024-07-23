using Market.BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Models
{
    public class ProductBusiness : BusinessEntity<int>
    {
        public ProductBusiness(int Id) : base(Id)
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Photo { get; set; }
        public string Amount { get; set; }
        public List<TransactionBusiness> Transactions { get; set; }
    }
}
