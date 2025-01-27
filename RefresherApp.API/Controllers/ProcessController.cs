using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RefresherApp.API.Controllers
{
    [ApiVersion(1)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        [MapToApiVersion(1)]
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var result = await 
            return Ok();
        }
        
        [MapToApiVersion(1)]
        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            //var result = await 
            return Ok();
        }


    }
}
