using Framework.Entities.Users;

namespace Framework.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> claims);
    }
}
