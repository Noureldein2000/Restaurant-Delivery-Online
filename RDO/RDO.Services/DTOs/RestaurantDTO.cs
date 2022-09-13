using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Services.DTOs
{
    public class RestaurantDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int CityID { get; set; }
    }
}
