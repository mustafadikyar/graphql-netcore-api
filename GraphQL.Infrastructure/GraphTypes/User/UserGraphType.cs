using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.User;
using GraphQL.DataLayer.Repository.Order;
using GraphQL.Infrastructure.GraphTypes.Order;
using GraphQL.Types;

namespace GraphQL.Infrastructure.GraphTypes.User
{
    public class UserGraphType : ObjectGraphType<UserDTO>, ISingletonGraphType
    {
        public UserGraphType()
        {
            IOrderService orderService = IoCManager.Resolve<IOrderService>();

            Field(user => user.Id);
            Field(user => user.Name);
            Field(user => user.Surname);
            Field(user => user.CompanyName, nullable: true);

            Field<ListGraphType<OrderGraphType>>(name: "orders",
                resolve: context =>
                {
                    return orderService.GetListByUserId(context.Source.Id);
                });
        }
    }
}
