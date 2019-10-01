using System.Collections.Generic;
using Egitim_Backend.Entities.Concrete.Categories;
using Egitim_Backend_Service.CategoryService;
using Egitim_Backend_Service.UserService;
using Egitim_Backend_Service.UserService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Egitim_Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICategoryAppService _categoryAppService;
        private readonly IUserAppService _userAppService;
        public ValuesController(ICategoryAppService categoryAppService,IUserAppService userAppService)
        {
            _categoryAppService = categoryAppService;
            _userAppService = userAppService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<List<Category>> Get()
        {
            return _categoryAppService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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