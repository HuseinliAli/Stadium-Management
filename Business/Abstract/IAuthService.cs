using Entities.Dtos.Users;
using Framework.Entities.Users;
using Framework.Utilities.Results;
using Framework.Utilities.Security.JWT;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto);
        Task<IDataResult<User>> LoginAsync(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
