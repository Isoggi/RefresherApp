﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RefresherApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var result = await 
            return Ok();
        }
    }
}
