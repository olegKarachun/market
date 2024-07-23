using Market.BLL.Models.Base;
using Market.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Models
{
    public class TransactionBusiness : BusinessEntity<int>
    {
        public TransactionBusiness(int Id) : base(Id)
        {
        }
        public int Id { get; set; }
        public CustomerBusiness Customers { get; set; }
        public ProductBusiness Products { get; set; }
        public int Amount { get; set; }
        public string Addres { get; set; }
    }
}
