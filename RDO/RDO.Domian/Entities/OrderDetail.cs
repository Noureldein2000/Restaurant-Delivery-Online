using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Entities
{
    public class OrderDetail : BaseEntity<int>
    {
        public int Quantity { get; set; }
        public double Total { get; set; }
        public int MenuId { get; set; }
        public int OrderId { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Order Order { get; set; }
    }
}
