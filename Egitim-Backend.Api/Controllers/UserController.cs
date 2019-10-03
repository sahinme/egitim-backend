using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Egitim_Backend_Service.UserService;
using Egitim_Backend_Service.UserService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Egitim_Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value1", "value2"};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(long id)
        {
            var ent =  _userAppService.GetById(id);
            return Ok(ent);
        }

        
        // POST api/values
        [HttpPost]
        public void Post([FromBody] CreateUserDto input)
        {
            _userAppService.Add(input);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}