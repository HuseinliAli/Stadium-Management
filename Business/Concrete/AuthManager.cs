using Business.Abstract;
using Business.Messages;
using Entities.Dtos.Users;
using Framework.Entities.Users;
using Framework.Utilities.Results;
using Framework.Utilities.Security.Hash;
using Framework.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userForRegisterDto.Password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userForRegisterDto.Email,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user, true,UserResultMessage.UserRegistered);
        }

        public async Task<IDataResult<User>> LoginAsync(UserForLoginDto userForLoginDto)
        {
            var userToCheck =await  _userService.GetByMailAsync(userForLoginDto.Email);
            if (userToCheck==null)
            {
                return new ErrorDataResult<User>(UserResultMessage.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(UserResultMessage.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck, true,UserResultMessage.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMailAsync(email)!=null)
            {
                return new ErrorResult(UserResultMessage.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims = _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, true,UserResultMessage.AccessTokenCreated);
        }
    }
}

