using Business.Abstract;
using Entities.Dtos.Centers;
using Entities.Dtos.Stadiums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace API.Controllers
{ 
    public class StadiumsController : BaseApiController
    {
        private readonly IStadiumService _stadiumService;

        public StadiumsController(IStadiumService stadiumService)
        {
            _stadiumService = stadiumService;
        }


        [HttpGet("byuser")]
        public async Task<IActionResult> GetStadiumsByUserId(int id)
        {
            var result = await _stadiumService.GetByUserId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> GetAll()
        {
            var result = await _stadiumService.GetAllWithDetailsAsync();
            if (result.Success)
            {
                return Ok(result.Data);    
            }
            return BadRequest(result.Message);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync(AddOrUpdateStadiumDto dto)
        {
            var result = await _stadiumService.AddAsync(dto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(int id, AddOrUpdateStadiumDto dto)
        {
            var result = await _stadiumService.UpdateAsync(id,dto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIdAync(int id)
        {
            var result = await _stadiumService.DeleteByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
