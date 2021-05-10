using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.Order;
using GraphQL.Types;

namespace GraphQL.Infrastructure.GraphTypes.Order
{
    public class OrderDetailGraphType : ObjectGraphType<OrderDetailDTO>, ISingletonGraphType
    {
        public OrderDetailGraphType()
        {
            Field(detail => detail.Id);
            Field(detail => detail.OrderId);
            Field(detail => detail.ProductName);
            Field(detail => detail.ProductPrice);
        }
    }
}
