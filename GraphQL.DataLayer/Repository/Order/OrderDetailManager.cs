using GraphQL.DataLayer.DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.DataLayer.Repository.Order
{
    public class OrderDetailManager : Repository<OrderDetailDTO>, IOrderDetailService
    {
        public List<OrderDetailDTO> GetListByOrderId(Guid orderId)
        {
            return DummyList.Where(s => s.OrderId == orderId).ToList();
        }
    }
}
