using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Domian.Entities
{
    public class BaseEntity<T>
    {
        public T ID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
