using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Optimizers.TestAssessment.DomainModels.DTO;
using Optimizers.TestAssessment.DomainModels.Models;
using Optimizers.TestAssessment.DomainServices.Interfaces;

namespace Optimizers.TestAssessment.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Create new instance of <see cref="UserController"/>.
        /// </summary>
        /// <param name="userService">The injected user service.</param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Save the new user record.
        /// </summary>
        /// <param name="userModel">Record to be saved.</param>
        /// <returns><see cref="UserModel"/> record.</returns>
        [HttpPost]
        public async Task<ActionResult<UserModel>> CreateUser([FromBody] UserModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = await _userService.CreateUser(new UserDTO(userModel));

            if (result == null)
            {
                return BadRequest();
            }

            var response = new UserModel
            {
                Id = result.Id,
                Password = result.Password,
                FullName = result.FullName,
                UserName = result.UserName
            };
            
            return Ok(response);
        }
        
    }
}