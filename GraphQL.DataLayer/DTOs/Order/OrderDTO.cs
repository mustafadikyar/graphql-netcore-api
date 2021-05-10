using System;

namespace GraphQL.DataLayer.DTOs.Order
{
    public class OrderDTO : BaseDTO
    {
        public Guid UserId { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
