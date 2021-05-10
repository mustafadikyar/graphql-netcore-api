using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.Order;
using GraphQL.DataLayer.Repository.Order;
using GraphQL.Infrastructure.GraphTypes.Order;
using GraphQL.Types;

namespace GraphQL.Infrastructure.Mutations
{
    public class OrderDetailMutation : ObjectGraphType, IMutationResolver
    {
        public OrderDetailMutation()
        {
            Name = nameof(OrderDetailMutation);
            IOrderDetailService orderDetailService = IoCManager.Resolve<IOrderDetailService>();

            Field<OrderDetailGraphType>(name: "insertOrderDetail",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<OrderDetailInputGraphType>> { Name = "inputModel" }),
                resolve: context =>
                {
                    OrderDetailDTO inputModel = context.GetArgument<OrderDetailDTO>("inputModel");
                    return orderDetailService.Insert(inputModel);
                }
            );
        }
    }
}
