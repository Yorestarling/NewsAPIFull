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
    public class CategoriesController : ControllerBase
    {
        private readonly NewsAPIsideContext _context;

        public CategoriesController(NewsAPIsideContext context)
        {
            _context = context;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Category>> AddCategory(Category model)
        {

            var category = new Category()
            {
                CategoryId = model.CategoryId,
                CategoryName = model.CategoryName, 
            };

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategory), new { q = category.CategoryName }, category);
          //  return CreatedAtAction("GetCategory", new { id = category.CategoryName }, category);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

    
        [HttpGet("{q}")]
        [AllowAnonymous]
        public async Task<ActionResult<Category>> GetCategory(String q)
        {
            var query = _context.Categories.AsQueryable().Where(a => a.CategoryName.Contains(q));

            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(a => a.CategoryName.Contains(q));
                var categoryS = query.Select(category => new CategoryDTO
                {
                    CategoryName = category.CategoryName,
                    
                }).ToArray();

                return Ok(categoryS);

            }
            return NotFound();
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
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
        //public async Task<ActionResult<Category>> PostCategory(Category category)
        //{
        //    _context.Categories.Add(category);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetCategory", new { id = category.CategoryId }, category);
        //}

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}
