using RDO.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Services.Services
{
    public interface IRestaurantService
    {
        RestaurantDTO AddRestaurant(RestaurantDTO model);
        List<RestaurantDTO> GetRestaurantsbyCity(int cityId);
        RestaurantDTO EditRestaurants(RestaurantDTO model);
        RestaurantDTO GetRestaurantsById(int? id);

    }
}
