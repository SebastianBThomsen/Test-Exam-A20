using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorAPI.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private LibraryDbContext _libraryDbContext;

        public BookController()
        {
            _libraryDbContext = new();
        }

        [HttpGet]
        public async Task<ActionResult<IList<Book>>> GetAsync()
        {
            try
            {
                IList<Book> books = await _libraryDbContext.Books.ToListAsync();
                return Ok(books);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [Route("{authorId:int}")]
        public async Task<ActionResult<Book>> PostAddAsync([FromBody] Book book, [FromRoute] int authorId)
        {
            Console.WriteLine($"Attempting to put {book} in Database with authorId {authorId}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Author authorReturn = await _libraryDbContext.Authors.Include(a => a.Book).FirstAsync(a => a.Id == authorId);
                Console.WriteLine("Before Book added" + authorReturn);
                authorReturn.Book.Add(book);
                Console.WriteLine("Before update" + authorReturn);
                _libraryDbContext.Update(authorReturn);
                Console.WriteLine("After update" + authorReturn);
                await _libraryDbContext.SaveChangesAsync();
                return Ok(book);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
        

        [HttpDelete]
        [Route("{bookId:int}")]
        public async Task<ActionResult> RemoveBook([FromRoute] int bookId)
        {
            try
            {
                Book bookToDelete = _libraryDbContext.Books.FirstOrDefault(b => b.ISBN == bookId);

                if (bookToDelete != null)
                {
                    _libraryDbContext.Books.Remove(bookToDelete);
                    await _libraryDbContext.SaveChangesAsync();
                    return Ok(bookToDelete);
                }
                return StatusCode(500, NotFound());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}