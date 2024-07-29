using Market.BLL.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Models
{
    public class CustomerBusiness : BusinessEntity
    {
        public CustomerBusiness()
        {
        }
        public string Email { get; set; }
        public string Name { get; set; }

        public List<TransactionBusiness> Transactions { get; set; }
    }
}
