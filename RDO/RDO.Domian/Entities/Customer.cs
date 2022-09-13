using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Entities
{
    public class Customer : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public virtual Order Order { get; set; }
    }
}
