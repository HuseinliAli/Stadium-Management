using Business.Abstract;
using Entities.Dtos.Rents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using System.Text.Json.Serialization;

namespace API.Controllers
{
    [Authorize]
    public class RentsController : BaseApiController
    {
        private readonly IRentService _rentService;

        public RentsController(IRentService rentService)
        {
            _rentService = rentService;
        }
        [HttpGet]
      
        public IActionResult GetAll()
        {
            var result = _rentService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getdetails")]
        public async Task<IActionResult> GetDetails()
        {
            var result =await _rentService.GetDetailRentDtos();
            return Ok(result);
        }

        [HttpPost("checkout1")]
        public async Task<IActionResult> Checkout1(AddOrUpdateRentDto dto)
        {
            var result = await _rentService.CheckoutForUser(dto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("checkout2")]
        public async Task<IActionResult> Checkout2(AddOrUpdateRentDto dto)
        {
            var result = await _rentService.CheckoutForUser(dto);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddOrUpdateRentDto dto)
        {
            var result =await  _rentService.AddAsync(dto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIdAync(int id)
        {
            var result = await _rentService.DeleteByIdAsync(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
