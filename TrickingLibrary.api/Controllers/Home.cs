using System;
using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "hellow ahmed";
        }
    }
}
