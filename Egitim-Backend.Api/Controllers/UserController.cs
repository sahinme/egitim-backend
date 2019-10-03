using System.Collections.Generic;
using System.Threading.Tasks;
using Egitim_Backend.Data.Abstract;
using Egitim_Backend.Entities.Concrete.Categories;
using Egitim_Backend.Entities.Concrete.Users;
using Egitim_Backend_Service.CategoryService;
using Egitim_Backend_Service.Dto;
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
//        [HttpGet]
//        public ActionResult<List<User>> GetAll()
//        {
//            return "va"
//        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Task<UserDto> Get(long id)
        {
            return _userAppService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post(CreateUserDto model)
        {
            _userAppService.Add(model);
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