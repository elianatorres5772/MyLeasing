using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyLeasing.Common.Models;
using MyLeasing.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Controllers.API
{

    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public OwnersController (DataContext dataContext )

            {
            _dataContext = dataContext;
        }

        [HttpPost]
        [Route("GetOnwerByEmail")] //llama el usrio 
        public  async Task<IActionResult> GetOnwerByEmailASync( EmailRequest Request)


        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var owner = await _dataContext.Owners
                
           .FirstOrDefaultAsync(o => o.User.Email.ToLower() == Request.Email.ToLower());


            if (owner == null)

            {
                return NotFound();

            }
            return Ok(owner);
        }
    }
}
