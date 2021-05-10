using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.Order;
using GraphQL.Types;

namespace GraphQL.Infrastructure.GraphTypes.Order
{
    public class OrderDetailInputGraphType : InputObjectGraphType<OrderDetailDTO>, ISingletonGraphType
    {
        public OrderDetailInputGraphType()
        {
            Field(detail => detail.OrderId);
            Field(detail => detail.ProductName);
            Field(detail => detail.ProductPrice);
        }
    }
}
