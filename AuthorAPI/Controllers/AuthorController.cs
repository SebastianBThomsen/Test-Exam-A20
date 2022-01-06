using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthorAPI.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AuthorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private LibraryDbContext _libraryDbContext;

        public AuthorController()
        {
            _libraryDbContext = new LibraryDbContext();
        }

        [HttpGet]
        public async Task<ActionResult<IList<Author>>> GetAsync()
        {
            try
            {
                IList<Author> authors = await _libraryDbContext.Authors.Include(a => a.Book).ToListAsync();
                return Ok(authors);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Author>> PostAddAsync([FromBody] Author author)
        {
            Console.WriteLine($"Attempting to put {author} in Database");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                EntityEntry<Author> returnAuthor = await _libraryDbContext.Authors.AddAsync(author);
                await _libraryDbContext.SaveChangesAsync();
                return returnAuthor.Entity;
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}