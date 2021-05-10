using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.DataLayer.Repository.Order;
using GraphQL.Infrastructure.GraphTypes.Order;
using GraphQL.Types;
using System;

namespace GraphQL.Infrastructure.Queries
{
    public class OrderDetailQuery : ObjectGraphType, IQueryResolver
    {
        public OrderDetailQuery()
        {
            Name = nameof(OrderDetailQuery);
            IOrderDetailService orderDetailService = IoCManager.Resolve<IOrderDetailService>();

            Field<ListGraphType<OrderGraphType>>(name: "getOrderDetails",
                resolve: context => { return orderDetailService.GetListByOrderId(context.GetArgument<Guid>("orderId")); }
                );
        }
    }
}
