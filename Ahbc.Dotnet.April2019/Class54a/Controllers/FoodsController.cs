using System.Linq;
using System.Threading.Tasks;
using Class54a.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Class54a.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly MenuDbContext _context;

        public FoodsController(MenuDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Food food)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest();
            }

            await _context.Foods.AddAsync(food);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Post", food);
        }

        [HttpGet]
        public async Task<IActionResult> Get(bool spicyOnly, int numberOfResults = 100)
        {
            IQueryable<Food> results;
            if (spicyOnly)
            {
                results = _context.Foods.Where(x => x.Spice > 1);
            }
            else
            {
                results = _context.Foods;
            }
            
            return Ok(await results.Take(numberOfResults).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var food = await _context.Foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }

            return Ok(food);
        }
    }
}