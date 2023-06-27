using ApiAuthAngular.Models.DTO;
using ApiAuthAngular.Repository.UserService;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAuthAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("authapi")]
    public class AngularAuthApi : ControllerBase
    {
        private readonly Userservice _userservice;
        public AngularAuthApi(Userservice userservice)
        {
            _userservice = userservice;
        }

        [HttpPost("Login")]
        public ActionResult<UserDTO> Login([FromBody] UserDTO userDTO)
        {
            var user = _userservice.Login(userDTO);
            if(user == null)
            {
                return BadRequest("Invalid username and password");
            }
            return Ok(user);
        }

        [HttpPost("Register")]
        public ActionResult<UserDTO> Register([FromBody] UserRegisterDTO userDTO)
        {
            var user = _userservice.Register(userDTO);
            if (user == null)
            {
                return BadRequest("Unable to register");
            }
            return Created("Home", user);
        }


    }
}
