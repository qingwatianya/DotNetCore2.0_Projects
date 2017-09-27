using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCore_Filter_Test_API.Filters;

namespace WebCore_Filter_Test_API.Controllers
{
    [Route("api/[controller]")]
    //[MyActionFilter]
    public class UsersController : Controller
    {
        private ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            throw new Exception("GetAll function failed!");
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = new User { Id = id, Name = "Name:" + id, Sex = "Male" };
            return new ObjectResult(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            // TODO：新增操作
            //user.Id = , );
            return CreatedAtAction("Get", new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            // TODO: 更新操作
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // TODO: 删除操作

        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
    }
}
