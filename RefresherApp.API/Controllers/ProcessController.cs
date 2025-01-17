using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RefresherApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var result = await 
            return Ok();
        }

        [Route("/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            //var result = await 
            return Ok();
        }


    }
}
