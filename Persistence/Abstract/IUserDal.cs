using Entities.Dtos.Admin;
using Entities.Dtos.Users;
using Framework.Entities.Users;
using Framework.Persistence.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Persistence.Abstract
{
    public interface IUserDal : IGenericRepository<User>
    {
        public List<OperationClaim> GetClaims(User user);
        public Task<UserWithRoleWithIdsDto> GetRolesById(int id);
        public Task<IQueryable<UserWithRolesDto>> GetWithRolesDtos();
        public Task DeleteFromRole(int userId, int claimId);
        public Task AddRoleTo(UserOperation userOperation);
        public Task<IQueryable<OperationClaim>> GetAllClaims();
        public Task<DashboardDto> GetAdminDashboardCounts();
    }
}