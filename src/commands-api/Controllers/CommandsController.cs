using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace commands_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new [] {"This", "is", "hard", "coded"};
        }
        
    }
}