using RDO.Services.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDO.Services.Services
{
    public interface IOrderService
    {
        OrderDTO AddOrder(OrderDTO model);
        List<OrderDTO> GetOrdersbyResturantId(int restId);
        List<OrderDTO> GetOrdersbyCustomerId(int restId);
        OrderDTO GetOrderbyId(int Id);
        OrderDTO EditOrder(OrderDTO model);

    }
}
