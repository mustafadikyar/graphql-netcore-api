using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.DataLayer.Repository.Order;
using GraphQL.Infrastructure.GraphTypes.Order;
using GraphQL.Types;
using System;

namespace GraphQL.Infrastructure.Queries
{
    public class OrderQuery : ObjectGraphType, IQueryResolver
    {
        public OrderQuery()
        {
            Name = nameof(OrderQuery);
            IOrderService orderService = IoCManager.Resolve<IOrderService>();

            Field<OrderGraphType>(name: "getOrder",
                arguments: new QueryArguments(new QueryArgument<GuidGraphType> { Name = "id" }),
                resolve: context => orderService.GetById(context.GetArgument<Guid>("id"))
                );

            Field<ListGraphType<OrderGraphType>>(name: "getOrders",
                resolve: context => { return orderService.GetAll(); }
                );
        }
    }
}
