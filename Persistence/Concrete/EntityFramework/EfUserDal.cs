using Entities.Dtos.Admin;
using Entities.Dtos.Users;
using Framework.Entities.Users;
using Framework.Persistence.EntityFramework;
using Framework.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using Persistence.Abstract;
using Persistence.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Concrete.EntityFramework
{
    public class EfUserDal : EfGenericRepository<User, MiniStadiumRentDbContext>, IUserDal
    {
        private readonly MiniStadiumRentDbContext _context;

        public EfUserDal(MiniStadiumRentDbContext context)
        {
            _context = context;
        }

        public async Task AddRoleTo(UserOperation userOperation)
        {
            await _context.UserOperations.AddAsync(userOperation);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFromRole(int userId, int claimId)
        {
            var deletedEntity = await _context.UserOperations.FirstOrDefaultAsync(uo=>uo.UserId == userId & uo.OperationClaimId==claimId);
            _context.UserOperations.Remove(deletedEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<DashboardDto> GetAdminDashboardCounts()
        {
            var year =await _context.Users.CountAsync(c => c.CreatedDate.Year ==DateTime.Today.Year);
            var month = await _context.Users.CountAsync(c => c.CreatedDate.Month ==DateTime.Today.Month);
            return new () {ThisMonthUserCount=month,ThisYearUserCount=year };
        }

        public async Task<IQueryable<OperationClaim>> GetAllClaims()
        {
            return _context.OperationClaims.Select(oc=>new OperationClaim() { Id=oc.Id,Name=oc.Name}).AsQueryable();
        }

        public List<OperationClaim> GetClaims(User user)
        {
            var result = from operationClaim in _context.OperationClaims
                         join userOperationClaim in _context.UserOperations
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
            return result.ToList();

        }

        public async Task<UserWithRoleWithIdsDto> GetRolesById(int id)
        {
            var result = await _context.Users
                        .Where(u => u.Id == id)
                        .Select(u => new UserWithRoleWithIdsDto
                        {
                            UserId = u.Id,
                            Claims = u.UserOperations
                                .Select(uo => new OperationClaim()
                                {
                                    Id = uo.OperationClaim.Id,
                                    Name=uo.OperationClaim.Name
                                })
                                .ToList()
                        })
                        .FirstOrDefaultAsync();
            return result;
        }

        public async Task<IQueryable<UserWithRolesDto>> GetWithRolesDtos()
        {
            var result = _context.Users
             .Include(u => u.UserOperations)
                 .ThenInclude(uo => uo.OperationClaim)
             .Select(user => new UserWithRolesDto
             {
                 UserId = user.Id,
                 FirstName = user.FirstName,
                 LastName = user.LastName,
                 Email=user.Email,
                 RoleNames = user.UserOperations.Select(uo => uo.OperationClaim.Name).ToList()
             })
             .AsQueryable();

            return result;
        }
    }
}
