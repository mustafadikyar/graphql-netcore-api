using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.Order;
using GraphQL.DataLayer.Repository.Order;
using GraphQL.Infrastructure.GraphTypes.Order;
using GraphQL.Types;

namespace GraphQL.Infrastructure.Mutations
{
    public class OrderMutation : ObjectGraphType, IMutationResolver
    {
        public OrderMutation()
        {
            Name = nameof(OrderMutation);
            IOrderService orderService = IoCManager.Resolve<IOrderService>();
            
            Field<OrderGraphType>(name: "insertOrder",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<OrderInputGraphType>> { Name = "inputModel" }),
                resolve: context =>
                {
                    OrderDTO inputModel = context.GetArgument<OrderDTO>("inputModel");
                    return orderService.Insert(inputModel);
                }
            );
        }
    }
}
