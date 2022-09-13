using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Entities
{
    public class Order : BaseEntity<int>
    {
        public int RestaurantId{ get; set; }
        public int CustomerId{ get; set; }
        public DateTime OrderDate { get; set; }
        public virtual Restaurant  Restaurant{ get; set; }
        public virtual Customer Customer{ get; set; }
        public virtual ICollection<OrderDetail> OrderDetails{ get; set; }
    }
}
