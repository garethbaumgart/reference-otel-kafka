using Microsoft.AspNetCore.Mvc;

namespace ProduceWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddName(string name)
        {
            return Ok();
        }
    }
}
