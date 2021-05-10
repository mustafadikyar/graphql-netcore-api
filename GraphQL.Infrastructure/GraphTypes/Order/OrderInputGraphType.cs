using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.Order;
using GraphQL.Types;

namespace GraphQL.Infrastructure.GraphTypes.Order
{
    public class OrderInputGraphType : InputObjectGraphType<OrderDTO>, ISingletonGraphType
    {
        public OrderInputGraphType()
        {
            Field(order => order.UserId);
            Field(order => order.DiscountPrice, nullable: true);
            Field(order => order.TotalPrice);
        }
    }
}
