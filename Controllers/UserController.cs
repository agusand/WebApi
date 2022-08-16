using Microsoft.AspNetCore.Mvc;
using PrimeraApi.Model;
using PrimeraApi.Repository;

namespace PrimeraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet(Name = "GetUsers")]
        public List<User> GetUsers()
        {

            return UserHandler.GetUsers();
        }
    }
}
