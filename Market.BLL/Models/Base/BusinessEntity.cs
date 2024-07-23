using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Models.Base
{
    public class BusinessEntity<IBusinessEntityId>
    {
        public BusinessEntity(IBusinessEntityId Id)
        {
            this.Id = Id;
        }

        public IBusinessEntityId Id { get; set; }
    }
}
