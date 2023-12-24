using Business.Abstract;
using Business.Aspects.Autofac;
using Business.Messages;
using Entities.Dtos.Admin;
using Entities.Dtos.Users;
using Framework.Entities.Users;
using Framework.Utilities.Results;
using Persistence.Abstract;
using Persistence.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
           _userDal.AddAsync(user);
        }

        [SecuredOperation("admin")]
        public async Task<IDataResult<IQueryable<UserWithRolesDto>>> GetWithRolesDtos()
        {

            return new SuccessDataResult<IQueryable<UserWithRolesDto>> (await _userDal.GetWithRolesDtos());
        }


        public async Task<User> GetByMailAsync(string email)
        {
            var user =await _userDal.GetAsync(u => u.Email == email);
            return user;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        [SecuredOperation("admin")]
        public async Task<DashboardDto> GetAdminDashboardCounts()
        {
            return await _userDal.GetAdminDashboardCounts();
        }


        [SecuredOperation("admin")]
        public async Task Remove(int id)
        {
             await _userDal.RemoveAsyncById(id);
        }
        [SecuredOperation("admin")]
        public async void Update(User user)
        {
            await _userDal.UpdateAsync(user);
        }

        [SecuredOperation("admin")]
        public async Task<IDataResult<UserWithRoleWithIdsDto>> GetRolesById(int id)
        {
            return new SuccessDataResult<UserWithRoleWithIdsDto>(await _userDal.GetRolesById(id));
        }
        [SecuredOperation("admin")]
        public async Task<IResult> DeleteFromRole(int userId, int claimId)
        {
            await _userDal.DeleteFromRole(userId, claimId);
            return new SuccessResult();
        }

        [SecuredOperation("admin")]
        public async Task<IResult> AddRoleTo(UserOperation userOperation)
        {
            await _userDal.AddRoleTo(userOperation);
            return new SuccessResult();
        }
        [SecuredOperation("admin")]
        public async Task<IDataResult<IQueryable<OperationClaim>>> GetAllClaims()
        {
            return new SuccessDataResult<IQueryable<OperationClaim>>(await _userDal.GetAllClaims());
        }
    }
}
