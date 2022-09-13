using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Services.DTOs
{
    public class OrderDetailDTO
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public int MenuId { get; set; }
        public int OrderId { get; set; }
    }
}
