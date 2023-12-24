using Business.Abstract;
using Business.Validations.FluentValidation;
using Entities.Dtos.Centers;
using Framework.Aspects.Autofac.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace API.Controllers
{
    public class CentersController : BaseApiController
    {
        private readonly ICenterService _centerService;

        public CentersController(ICenterService centerService)
        {
            _centerService = centerService;
        }


        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> GetAll()
        {
            var result =await _centerService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("byuser")]
        [EnableQuery]
        public async Task<IActionResult> GetCentersByUserId(int id)
        {
            var result = _centerService.GetByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddAsync(AddOrUpdateCenterDto dto)
        {
            var result = await _centerService.AddAsync(dto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> UpdateAsync(int id,AddOrUpdateCenterDto dto)
        {
            var result = await _centerService.UpdateAsync(id,dto);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteByIdAync(int id)
        {
            var result = await _centerService.DeleteByIdAsync(id);
            if(result.Success)
            {
                return Ok(result);  
            }
            return BadRequest(result);
        }
    }
}
