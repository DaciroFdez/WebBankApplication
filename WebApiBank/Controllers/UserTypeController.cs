using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiBank.DataBase;
using WebApiBank.DTOs;
using WebApiBank.Models;

namespace WebApiBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase
    {
        private readonly BankApiDB _dbContex;

        public UserTypeController(BankApiDB dbContext)
        {
            _dbContex = dbContext;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateUserType([FromBody] UserTypeDTO userTypeDTO)
        {
            try
            {
                var userType = new UserType()
                {
                    UserTypeName = userTypeDTO.UserTypeName
                };

                _dbContex.UserTypes.Add(userType);
                await _dbContex.SaveChangesAsync();
                return Ok("Creado");
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
