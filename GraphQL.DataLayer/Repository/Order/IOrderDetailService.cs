using GraphQL.DataLayer.DTOs.Order;
using System;
using System.Collections.Generic;

namespace GraphQL.DataLayer.Repository.Order
{
    public interface IOrderDetailService : IRepository<OrderDetailDTO>
    {
        public List<OrderDetailDTO> GetListByOrderId(Guid orderId);
    }
}
