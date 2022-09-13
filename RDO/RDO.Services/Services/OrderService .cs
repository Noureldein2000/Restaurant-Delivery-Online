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
    public class OrderService : IOrderService
    {
        private readonly IBaseRepository<Order, int> _orderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(
            IBaseRepository<Order, int> orderRepository,
            IUnitOfWork unitOfWork
            )
        {
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
        }


        public OrderDTO AddOrder(OrderDTO model)
        {
            var addedEntity = _orderRepository.Add(new Order
            {
                RestaurantId = model.RestaurantId,
                CustomerId = model.CustomerId,
                OrderDate = model.OrderDate,
                OrderDetails = model.OrderDetailsDTO.Select(x => new OrderDetail
                {
                    Quantity = x.Quantity,
                    Total = x.Total,
                    MenuId = x.MenuId
                }).ToList()
            });

            model.ID = addedEntity.ID;
            return model;
        }

        public List<OrderDTO> GetOrdersbyResturantId(int restId)
        {
            return _orderRepository.Getwhere(x => x.RestaurantId == restId).Select(model => new OrderDTO
            {
                RestaurantId = model.RestaurantId,
                CustomerId = model.CustomerId,
                OrderDate = model.OrderDate,
                OrderDetailsDTO = model.OrderDetails.Select(x => new OrderDetailDTO
                {
                    Quantity = x.Quantity,
                    Total = x.Total,
                    MenuId = x.MenuId
                }).ToList()
            }).ToList();
        }

        public List<OrderDTO> GetOrdersbyCustomerId(int customerId)
        {
            return _orderRepository.Getwhere(x => x.CustomerId == customerId).Select(model => new OrderDTO
            {
                RestaurantId = model.RestaurantId,
                CustomerId = model.CustomerId,
                OrderDate = model.OrderDate,
                OrderDetailsDTO = model.OrderDetails.Select(x => new OrderDetailDTO
                {
                    Quantity = x.Quantity,
                    Total = x.Total,
                    MenuId = x.MenuId
                }).ToList()
            }).ToList();
        }

        public OrderDTO GetOrderbyId(int Id)
        {
            return _orderRepository.Getwhere(x => x.ID == Id).Select(model => new OrderDTO
            {
                RestaurantId = model.RestaurantId,
                CustomerId = model.CustomerId,
                OrderDate = model.OrderDate,
                OrderDetailsDTO = model.OrderDetails.Select(x => new OrderDetailDTO
                {
                    Quantity = x.Quantity,
                    Total = x.Total,
                    MenuId = x.MenuId
                }).ToList()
            }).FirstOrDefault();
        }

        public OrderDTO EditOrder(OrderDTO model)
        {
            throw new NotImplementedException();
        }

    }
}

