using Framework.Entities;
using Framework.Entities.Users;

namespace Entities.Dtos.Users
{
    public class UserWithRoleWithIdsDto:IDto
    {
        public int UserId { get; set;}
        public List<OperationClaim> Claims { get; set; } = new List<OperationClaim>();
    }
}
