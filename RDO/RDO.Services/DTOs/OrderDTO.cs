using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Services.DTOs
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public int RestaurantId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetailDTO> OrderDetailsDTO { get; set; }

    }
}
