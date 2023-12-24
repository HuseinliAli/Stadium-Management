using Business.Abstract;
using Framework.Entities.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [Authorize]
        [EnableQuery]
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result =await _userService.GetWithRolesDtos();
            if (result.Success)
            {
                return  Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getrolesbyid")]
        [Authorize]
        public async Task<IActionResult> GetRolesById(int id)
        {
            var result = await _userService.GetRolesById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Edit(User user)
        {
            _userService.Update(user);
            return Ok();
        }
        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteByIdAync(int id)
        {
            await  _userService.Remove(id);
            return Ok();
        }

        [HttpDelete("removefromrole")]
        [Authorize]
        public async Task<IActionResult> DeleteFromRole(int userId, int claimId)
        {
            var result = await _userService.DeleteFromRole(userId, claimId);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest(result);
        }

        [HttpPost("addroleto")]
        [Authorize]
        public async Task<IActionResult> AddRoleTo(UserOperation userOperation)
        {
            var result = await _userService.AddRoleTo(userOperation);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest(result);
        }

        [HttpGet("getallclaims")]
        [Authorize]
        public async Task<IActionResult> GetAllClaims()
        {
            var result = await _userService.GetAllClaims();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        
    }
}
