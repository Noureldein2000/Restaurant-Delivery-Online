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
    public class MenuService : IMenuService
    {
        private readonly IBaseRepository<Menu, int> _menuRepository;
        private readonly IUnitOfWork _unitOfWork;

        public MenuService(
            IBaseRepository<Menu, int> menuRepository,
            IUnitOfWork unitOfWork
            )
        {
            _menuRepository = menuRepository;
            _unitOfWork = unitOfWork;
        }


        public MenuDTO AddMenu(MenuDTO model)
        {
            var addedEntity = _menuRepository.Add(new Menu
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                Price = model.Price,
                RestaurantId = model.RestaurantId
            });

            model.ID = addedEntity.ID;
            return model;

        }

        public List<MenuDTO> GetMenusbyResturantId(int restId)
        {
            return _menuRepository.Getwhere(x => x.RestaurantId == restId).Select(model => new MenuDTO
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                Price = model.Price,
                RestaurantId = model.RestaurantId
            }).ToList();
        }

        public MenuDTO EditMenus(MenuDTO model)
        {
            throw new NotImplementedException();
        }

        public MenuDTO GetMenusbyId(int id)
        {
            return _menuRepository.Getwhere(x => x.ID == id).Select(model => new MenuDTO
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                Price = model.Price,
                RestaurantId = model.RestaurantId
            }).FirstOrDefault();
        }

        public MenuDTO EditMenu(MenuDTO model)
        {
            throw new NotImplementedException();
        }
    }
}

