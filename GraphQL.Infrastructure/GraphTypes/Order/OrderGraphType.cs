using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.Order;
using GraphQL.DataLayer.Repository.Order;
using GraphQL.DataLayer.Repository.User;
using GraphQL.Infrastructure.GraphTypes.User;
using GraphQL.Types;

namespace GraphQL.Infrastructure.GraphTypes.Order
{
    public class OrderGraphType : ObjectGraphType<OrderDTO>, ISingletonGraphType
    {
        public OrderGraphType()
        {
            IOrderDetailService orderDetailService = IoCManager.Resolve<IOrderDetailService>();
            IUserService userService = IoCManager.Resolve<IUserService>();

            Field(order => order.Id);
            Field(order => order.UserId);
            Field(order => order.DiscountPrice, nullable: true);
            Field(order => order.TotalPrice);

            Field<UserGraphType>(name: "user",
                resolve: context =>
                {
                    return userService.GetById(context.Source.UserId);
                });

            Field<ListGraphType<OrderDetailGraphType>>(name: "details",
                resolve: context =>
                {
                    return orderDetailService.GetListByOrderId(context.Source.Id);
                }
            );
        }
    }
}
