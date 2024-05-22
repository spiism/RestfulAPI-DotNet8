using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestfulAPI_DotNet8.Data;
using RestfulAPI_DotNet8.Entities;

namespace RestfulAPI_DotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        //public async Task<IActionResult> GetAllHeroes()
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            //var heroes = new List<SuperHero>
            //{
            //    new SuperHero
            //    {
            //        Id = 1,
            //        Name = "Spiderman",
            //        FirstName = "Perter",
            //        LastName = "Parker",
            //        Place = "New York City"
            //    }
            //};

            var heroes = await _context.SuperHeroes.ToListAsync();
            return Ok(heroes);
        }
    }
}
