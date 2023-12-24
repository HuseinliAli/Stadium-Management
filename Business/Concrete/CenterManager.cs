using Business.Abstract;
using Business.Aspects.Autofac;
using Business.Messages;
using Business.Validations.FluentValidation.Center;
using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Centers;
using Entities.Mappings;
using Framework.Aspects.Autofac.Caching;
using Framework.Aspects.Autofac.Validation;
using Framework.CrossCuttingConcerns.Validation.FluentValidation;
using Framework.Utilities.Business;
using Framework.Utilities.Results;
using Persistence.Abstract;

namespace Business.Concrete
{
    public class CenterManager : ICenterService
    {
        private readonly ICenterDal _centerDal;
        public CenterManager(ICenterDal centerDal)
        {
            _centerDal = centerDal;
        }


        [SecuredOperation("admin,vendor,center.add")]
        [ValidationAspect(typeof(CenterValidator))]
        public async Task<IResult> AddAsync(AddOrUpdateCenterDto dto)
        {
            await _centerDal.AddAsync(CenterMappingExtensions.AsAddEntity(dto));

            return new SuccessResult(CenterResultMessage.Added);
        }

        [SecuredOperation("admin,vendor,center.remove")]
        public async Task<IResult> DeleteByIdAsync(int id)
        {
            await _centerDal.RemoveAsyncById(id);

            return new SuccessResult(CenterResultMessage.Removed);
        }
        [SecuredOperation("admin")]
        public async Task<DashboardDto> GetAdminDashboardCounts()
        {
            return await _centerDal.GetAdminDashboardCounts();
        }

        [CacheAspect]
        public async Task<IDataResult<IQueryable<CenterDetailDto>>> GetAllAsync()
        {
            return new SuccessDataResult<IQueryable<CenterDetailDto>>(await _centerDal.GetAllWithDetails(),true, CenterResultMessage.Listed);
        }

        public  IDataResult<List<Center>> GetByUserId(int id)
        {
            var result = _centerDal.GetAllAsync().Result.Where(x=>x.CreatedById==id).ToList();
            return new SuccessDataResult<List<Center>>(result);
        }

        [ValidationAspect(typeof(AddOrUpdateCenterDto))]
        [SecuredOperation("admin,vendor,center.update")]
        public async Task<IResult> UpdateAsync(int id, AddOrUpdateCenterDto dto)
        {
            var entity = CenterMappingExtensions.AsUpdateDto(await _centerDal.GetAsync(x=>x.Id == id));
            await _centerDal.UpdateAsync(CenterMappingExtensions.AsUpdateEntity(entity));
            return new SuccessResult(CenterResultMessage.Updated);
        }
    }
}
