using GraphQL.DataLayer;
using GraphQL.DataLayer.DTOs.User;
using GraphQL.Types;

namespace GraphQL.Infrastructure.GraphTypes.User
{
    public class UserInputGraphType : InputObjectGraphType<UserDTO>, ISingletonGraphType
    {
        public UserInputGraphType()
        {
            Field(user => user.Name);
            Field(user => user.Surname);
            Field(user => user.CompanyName, nullable: true);
        }
    }
}
