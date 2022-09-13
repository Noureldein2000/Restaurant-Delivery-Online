using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Entities
{
    public class Menu : BaseEntity<int>
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurants { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
