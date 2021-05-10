using GraphQL.BusinessLayer.DependencyResolvers.CastleWindsor;
using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.User;
using GraphQL.DataLayer.Repository.User;
using GraphQL.Infrastructure.GraphTypes.User;
using GraphQL.Types;

namespace GraphQL.Infrastructure.Mutations
{
    public class UserMutation : ObjectGraphType, IMutationResolver
    {
        public UserMutation()
        {
            Name = "UserMutation";
            IUserService userService = IoCManager.Resolve<IUserService>();

            Field<UserGraphType>(name: "insertUser",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<UserInputGraphType>> { Name = "inputModel" }),
                resolve: context =>
                {
                    UserDTO inputModel = context.GetArgument<UserDTO>("inputModel");
                    return userService.Insert(inputModel);
                }
            );
        }
    }
}
