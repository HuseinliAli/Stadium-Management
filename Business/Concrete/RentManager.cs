using Business.Abstract;
using Business.Aspects.Autofac;
using Business.Messages;
using Business.Validations.FluentValidation.Center;
using Business.Validations.FluentValidation.Rent;
using Entities.Concrete;
using Entities.Dtos.Admin;
using Entities.Dtos.Centers;
using Entities.Dtos.Rents;
using Entities.Mappings;
using Framework.Aspects.Autofac.Caching;
using Framework.Aspects.Autofac.Validation;
using Framework.Utilities.Business;
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
    public class RentManager : IRentService
    {
        private readonly IRentDal _rentDal;
        private IStadiumService _stadiumService;
        public RentManager(IRentDal rentDal, IStadiumService stadiumService)
        {
            _rentDal = rentDal;
            _stadiumService = stadiumService;
        }

        [ValidationAspect(typeof(RentValidator))]
        public async Task<IResult> AddAsync(AddOrUpdateRentDto dto)
        {
            var newDto = await CheckOut(dto);
            var result = BusinessRules.Run(CheckIsAvailable(newDto.StadiumId, newDto.Start, newDto.Finish));

            if (result != null)
            {
                return result;
            }

            await _rentDal.AddAsync(RentMappingExtensions.AsAddEntity(newDto));

            return new SuccessResult(RentResultMessage.Added);
        }
        [ValidationAspect(typeof(RentValidator))]
        public async Task<IDataResult<AddOrUpdateRentDto>> CheckoutForUser(AddOrUpdateRentDto dto)
        {
            var newDto = await CheckOut(dto);
            var result = BusinessRules.Run(CheckIsAvailable(newDto.StadiumId, newDto.Start, newDto.Finish));

            if (result != null)
            {
                return  new ErrorDataResult<AddOrUpdateRentDto>(newDto,false, RentResultMessage.AddFailed);
            }
            return new SuccessDataResult<AddOrUpdateRentDto>(newDto,true,RentResultMessage.Avialiable);
        }

        [SecuredOperation("admin")]
        public async Task<DashboardDto> GetAdminDashboardCounts()
        {
            return await _rentDal.GetAdminDashboardCounts();
        }

        [SecuredOperation("admin,rent.remove")]
        public async Task<IResult> DeleteByIdAsync(int id)
        {
            await _rentDal.RemoveAsyncById(id);

            return new SuccessResult(RentResultMessage.Removed);
        }

        public IDataResult<IQueryable<Rent>> GetAll()
        {
            return new SuccessDataResult<IQueryable<Rent>>(_rentDal.GetAll(), true, RentResultMessage.Listed);
        }


        private IResult CheckIsAvailable(int stadiumId, DateTime startTime, DateTime finishTime)
        {
            var rents = _rentDal.GetAll().Where(i => i.StadiumId == stadiumId).ToList();
            if (rents == null)
            {
                return new SuccessResult();
            }
            foreach (var rent in rents)
            {
                if (!(rent.Start>= finishTime || rent.Finish<=startTime))
                {
                    return new ErrorResult(RentResultMessage.Rented);
                }
            }
            return new SuccessResult();
        }
        public async Task<AddOrUpdateRentDto> CheckOut(AddOrUpdateRentDto dto)
        {
            var stadiums = await _stadiumService.GetAllAsync();
            var stadium = stadiums.Data.FirstOrDefault(s => s.Id == dto.StadiumId);
            return new()
            {
                Start = dto.Start,
                Finish = dto.Start.AddHours(1),
                Price = CalculatePrice(dto, stadium),
                Tax = CalculatePrice(dto, stadium)*0.18,
                TotalPrice = CalculatePrice(dto, stadium) + CalculatePrice(dto, stadium)*0.18,
                UserId = dto.UserId,
                CreatedDate = DateTime.Now,
                StadiumId = dto.StadiumId
            };
        }
        private double CalculatePrice(AddOrUpdateRentDto dto, Stadium stadium)
        {
            if (dto.Start.Hour>=5 && dto.Start.Hour<=12)
            {
                return stadium.PriceMorning;
            }
            else if (dto.Start.Hour>12 && dto.Start.Hour <=17)
            {
                return stadium.PriceAfternoon;
            }
            return stadium.PriceEvening;
        }

        public async Task<List<GetDetailRentDto>> GetDetailRentDtos()
        {
            return await  _rentDal.GetDetailRentDtos();
        }
    }
}
