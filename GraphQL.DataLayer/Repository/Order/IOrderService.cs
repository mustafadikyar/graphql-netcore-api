using GraphQL.DataLayer.DTOs.Order;
using System;
using System.Collections.Generic;

namespace GraphQL.DataLayer.Repository.Order
{
    public interface IOrderService : IRepository<OrderDTO>
    {
        public List<OrderDTO> GetListByUserId(Guid userId);
    }
}
