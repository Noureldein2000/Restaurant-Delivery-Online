using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Entities
{
    public class Restaurant : BaseEntity<int>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int CityId{ get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Order Order{ get; set; }
        public virtual City City{ get; set; }
    }
}
