using Microsoft.EntityFrameworkCore;
using RDO.Domian.Entities;
using RDO.Services.DTOs;
using RDO.Services.Repositories;
using RDO.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RDO.Services.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IBaseRepository<Restaurant, int> _resturantRepository;
        private readonly IUnitOfWork _unitOfWork;

        public RestaurantService(
            IBaseRepository<Restaurant, int> resturantRepository,
            IUnitOfWork unitOfWork
            )
        {
            _resturantRepository = resturantRepository;
            _unitOfWork = unitOfWork;
        }


        public RestaurantDTO AddRestaurant(RestaurantDTO model)
        {
            var addedEntity = _resturantRepository.Add(new Restaurant
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                CityId = model.CityID,
            });
            _unitOfWork.SaveChanges();
            model.ID = addedEntity.ID;
            return model;

        }

        public List<RestaurantDTO> GetRestaurantsbyCity(int cityId)
        {
            return _resturantRepository.Getwhere(x => x.CityId == cityId).Select(f => new RestaurantDTO
            {
                ID = f.ID,
                Name = f.Name,
                ImageUrl = f.ImageUrl,
                CityID = f.CityId,
            }).ToList();
        }

        public RestaurantDTO EditRestaurants(RestaurantDTO model)
        {
            throw new NotImplementedException();
        }

        public RestaurantDTO GetRestaurantsById(int? id)
        {
            return _resturantRepository.Getwhere(x => id != null ? x.ID == id : true).Select(f => new RestaurantDTO
            {
                ID = f.ID,
                Name = f.Name,
                ImageUrl = f.ImageUrl,
                CityID = f.CityId
            }).FirstOrDefault();
        }
    }
}

