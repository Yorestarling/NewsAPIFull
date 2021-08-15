using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APInewsREST.Data;
using APInewsREST.Models;
using Microsoft.AspNetCore.Authorization;

namespace APInewsREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly NewsAPIsideContext _context;

        public AuthorsController(NewsAPIsideContext context)
        {
            _context = context;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Author>> AddAuthors(Author model)
        {

            var Authors = new Author()
            {
                AuthorId = model.AuthorId,
                UsersId = model.UsersId,
                AuthorName = model.AuthorName
            };

            await _context.Authors.AddAsync(Authors);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAuthors), new { id = Authors.AuthorId }, Authors);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return await _context.Authors.Select(item => new Author
            {
                AuthorId = item.AuthorId,
                UsersId = item.UsersId,
                AuthorName = item.AuthorName
            }).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            var author = await _context.Authors.FindAsync(id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthor(int id, Author author)
        {
            if (id != author.AuthorId)
            {
                return BadRequest();
            }

            _context.Entry(author).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

       
        //[HttpPost]
        //public async Task<ActionResult<Author>> PostAuthor(Author author)
        //{
        //    _context.Authors.Add(author);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAuthor", new { id = author.AuthorId }, author);
        //}

     
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                return NotFound();
            }

            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AuthorExists(int id)
        {
            return _context.Authors.Any(e => e.AuthorId == id);
        }
    }
}
