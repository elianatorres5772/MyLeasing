using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLeasing.Common.Models;

namespace MyLeasing.Web.Controllers.API
{

    [Route("api/[controller]")]
    [ApiController]

    public class OwnersController : ControllerBase
    {
        [HttpPost]

        public IActionResult GetOwnerByEmail(EmailRequest emailRequest )

        {
            return Ok();
        }
        

    }
}
