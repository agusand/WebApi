using Microsoft.AspNetCore.Mvc;
using PrimeraApi.Model;

namespace PrimeraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "GetUsers")]
        public List<User> GetUsers()
        {
            return new List<User>() { new User { Id = 1, Name = "Agus" } };
        }
    }
}
