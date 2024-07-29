using Market.BLL.Models.Base;
using Market.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Models
{
    public class TransactionBusiness : BusinessEntity
    {
        public TransactionBusiness()
        {
        }
        public CustomerBusiness Customers { get; set; }
        public ProductBusiness Products { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public string Addres { get; set; }
    }
}
