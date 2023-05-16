using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_intro.Controllers
{
    [Route("api/[controller]/[action]")] //localhostdan sonrakilar bunlar olur, yeni root
    [ApiController]
    public class EmployeeController : ControllerBase //mvcdeki controllerde view return etmek olur. controllerBase de ise olmur. yalniz return ok();
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            string[] names = { "Eli", "Jale", "Pervin" };
            return Ok(names);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            if (id == null) return BadRequest(string.Empty);
            return Ok("Eli" + " " + id);
        }
    }
}
