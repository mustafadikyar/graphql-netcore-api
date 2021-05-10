using GraphQL.DataLayer.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.DataLayer.Repository.Order
{
    public  class OrderManager : Repository<OrderDTO>, IOrderService
    {
        public List<OrderDTO> GetListByUserId(Guid userId)
        {
            return DummyList.Where(s => s.UserId == userId).ToList();
        }
    }
}
