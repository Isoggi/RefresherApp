using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RefresherApp.API.Controllers
{
    [ApiVersion(1)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        [MapToApiVersion(1)]
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var result = await 
            return Ok();
        }
    }
}
