using Business.Abstract;
using Business.Aspects.Autofac;
using Business.Messages;
using Business.Validations.FluentValidation;
using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Stadiums;
using Entities.Mappings;
using Framework.Aspects.Autofac.Caching;
using Framework.Aspects.Autofac.Validation;
using Framework.Utilities.Results;
using Persistence.Abstract;
using Persistence.Concrete.EntityFramework;

namespace Business.Concrete
{
    public class StadiumManager : IStadiumService
    {
        private readonly IStadiumDal _stadiumDal;

        public StadiumManager(IStadiumDal stadiumDal)
        {
            _stadiumDal = stadiumDal;
        }

        [ValidationAspect(typeof(StadiumValidator))]
        [SecuredOperation("admin,vendor,stadium.add")]
        public async Task<IResult> AddAsync(AddOrUpdateStadiumDto dto)
        {
            await _stadiumDal.AddAsync(StadiumMappingExtensions.AsAddEntity(dto));

            return new SuccessResult(StadiumResultMessage.Added);
        }

        [SecuredOperation("admin,vendor,stadium.remove")]
        public async Task<IResult> DeleteByIdAsync(int id)
        {
            await _stadiumDal.RemoveAsyncById(id);
            return new SuccessResult(StadiumResultMessage.Removed);
        }

        [CacheAspect]
        public async Task<IDataResult<IQueryable<StadiumWithCenterDto>>> GetAllWithDetailsAsync()
        {
            return new SuccessDataResult<IQueryable<StadiumWithCenterDto>>(await _stadiumDal.GetAllWithDetailsAsync(),true,StadiumResultMessage.Listed);
        }
        [ValidationAspect(typeof(StadiumValidator))]
        [SecuredOperation("admin,vendor,stadium.update")]
        public async Task<IResult> UpdateAsync(int id,AddOrUpdateStadiumDto dto)
        {
            var entity = StadiumMappingExtensions.AsUpdateDto(await _stadiumDal.GetAsync(s=>s.Id == id));
            await _stadiumDal.UpdateAsync(StadiumMappingExtensions.AsUpdateEntity(entity));

            return new SuccessResult(StadiumResultMessage.Updated);
        }

        [SecuredOperation("admin")]
        public async Task<DashboardDto> GetAdminDashboardCounts()
        {
            return await _stadiumDal.GetAdminDashboardCounts();
        }

        public async Task<IDataResult<ICollection<Stadium>>> GetAllAsync()
        {
            return new SuccessDataResult<ICollection<Stadium>>(await _stadiumDal.GetAllAsync(), true, StadiumResultMessage.Listed);
        }

        public async Task<IDataResult<ICollection<Stadium>>> GetByUserId(int id)
        {
            var result = GetAllAsync().Result.Data.Where(x => x.CreatedById==id).ToList();
            return new SuccessDataResult<ICollection<Stadium>>(result);
        }
    }
}
