using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PerfoEvo.Models;

namespace PerfoEvo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GezondheidController : ControllerBase
    {
        private readonly PerfoEvoContext _context;

        public GezondheidController(PerfoEvoContext context)
        {
            _context = context;
        }

        // GET: api/Gezondheid
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gezondheid>>> GetGezondheid()
        {
            return await _context.Gezondheid.ToListAsync();
        }

        // DELETE: api/Gezondheid/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Gezondheid>> DeleteGezondheid(int id)
        {
            var gezondheid = await _context.Gezondheid.FindAsync(id);
            if (gezondheid == null)
            {
                return NotFound();
            }

            _context.Gezondheid.Remove(gezondheid);
            await _context.SaveChangesAsync();

            return gezondheid;
        }

        private bool GezondheidExists(int id)
        {
            return _context.Gezondheid.Any(e => e.Id == id);
        }
    }
}
