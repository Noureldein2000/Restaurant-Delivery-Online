using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Services.DTOs
{
    public class MenuDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
        public string ImageUrl{ get; set; }
        public double Price{ get; set; }
        public int RestaurantId{ get; set; }

    }
}
