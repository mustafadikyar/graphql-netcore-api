using System;

namespace GraphQL.DataLayer.DTOs.Order
{
    public class OrderDetailDTO : BaseDTO
    {
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
