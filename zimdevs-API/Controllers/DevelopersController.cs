using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using zimdevsapi.Models.DTOs;
using zimdevsapi.Repositories.Interfaces;

namespace zimdevsapi.Controllers
{
    [Produces("application/json")]
    [Route("api/Developers")]
    public class DevelopersController : Controller
    {
        public DevelopersController(IDeveloperRepository repository, IMapper mapper)
        {

            Repository = repository;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetDevelopers()
        {

            var devs = await Repository.GetDevelopers();

            return Ok(Mapper.Map<List<DeveloperDTO>>(devs));
        }

        public IDeveloperRepository Repository { get; }
        public IMapper Mapper { get; }
    }
}