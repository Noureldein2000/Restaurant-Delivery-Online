using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Entities
{
    public class City : BaseEntity<int>
    {
        public string Name { get; set; }
        public virtual ICollection<Restaurant> Restaurants{ get; set; }
    }
}
