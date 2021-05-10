using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.DataLayer.Repository.User;
using GraphQL.Infrastructure.GraphTypes.User;
using GraphQL.Types;
using System;

namespace GraphQL.Infrastructure.Queries
{
    public class UserQuery : ObjectGraphType, IQueryResolver
    {
        public UserQuery()
        {
            Name = nameof(UserQuery);
            IUserService userService = IoCManager.Resolve<IUserService>();

            Field<UserGraphType>(name: "getUser",
                arguments: new QueryArguments(new QueryArgument<GuidGraphType> { Name = "id" }),
                resolve: context => userService.GetById(context.GetArgument<Guid>("id"))
                );

            Field<ListGraphType<UserGraphType>>(name: "getUsers",
                resolve: context => { return userService.GetAll(); }
                );
        }
    }
}
