using Entities.Dtos.Admin;
using Entities.Dtos.Users;
using Framework.Entities.Users;
using Framework.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        Task Remove(int id);
        void Update(User user);
        Task<User> GetByMailAsync(string email);
        public Task<IDataResult<IQueryable<UserWithRolesDto>>> GetWithRolesDtos();
        public Task<IDataResult<UserWithRoleWithIdsDto>> GetRolesById(int id);
        public Task<IResult> DeleteFromRole(int userId, int claimId);
        public Task<IResult> AddRoleTo(UserOperation userOperation);
        public Task<IDataResult<IQueryable<OperationClaim>>> GetAllClaims();
        public Task<DashboardDto> GetAdminDashboardCounts();
    }
}
