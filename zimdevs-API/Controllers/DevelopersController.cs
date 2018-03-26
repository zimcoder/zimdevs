using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using zimdevsapi.Models;

namespace zimdevsapi.Controllers
{
    [Produces("application/json")]
    [Route("api/Developers")]
    public class DevelopersController : Controller
    {
        public DevelopersController(ZimDevsDbContext context)
        {
            Context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDevelopers()
        {
            var devs = await Context.Developers.ToListAsync();
            return Ok(devs);
        }

        public ZimDevsDbContext Context { get; }
    }
}