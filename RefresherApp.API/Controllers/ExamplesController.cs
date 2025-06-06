using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
namespace RefresherApp.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var result = await 
            return await Task.FromResult(Ok());
        }
    }
}
