using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Banca.API.Controllers
{
    [Route("User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var Elisa = new Banca.API.User.User("01260003806", "elisa99ms@gmail.com");
            var Paulo = new Banca.API.User.User
            {
                Email = "paulodaniel@usp.br",
                CPF = "090123"
            };

            var userList = new List<Banca.API.User.User>
            {
                Elisa,
                Paulo
            };

            return Ok(userList);
        }
    }
}