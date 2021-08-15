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

using System.Net.Http;



namespace APInewsREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly NewsAPIsideContext _context;

        public ArticlesController(NewsAPIsideContext context)
        {
            _context = context;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Article>> AddArticles(Article model)
        {

            var articles = new Article()
            {
                AuthorId = model.AuthorId,
                Title = model.Title,
                Descriptions = model.Descriptions,
                Ulr = model.Ulr,
                CountriesId = model.CountriesId,
                CategoryId = model.CategoryId,
                SourcesId = model.SourcesId,
                UlrToImage = model.UlrToImage,
                Content = model.Content
            };
 
            await _context.Articles.AddAsync(articles);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetArticle), new { q = articles.Title }, articles);
        }
        
        [HttpGet]
        [AllowAnonymous]
        public ActionResult GetArticles()
        {

             var query = _context.Articles.AsQueryable();

                 var articles = query.Select(articles => new ArticlesDTO
                 {
                     Title = articles.Title,
                     Descriptions = articles.Descriptions,
                     Content = articles.Content,
                     AuthorName = articles.Author.AuthorName,
                     UlrToImage = articles.UlrToImage,
                     Ulr = articles.Ulr,
                     PublishedAt = articles.PublishedAt,
                     CategoryName = articles.Category.CategoryName,
                     CountriesName = articles.Countries.ContriesName,
                     SourcesName = articles.Sources.SourcesName
                 }).ToArray();

                 return Ok(articles);
        }


        // GET: api/Articles/5
        [HttpGet("{q}")]
        [AllowAnonymous]
        public async Task<ActionResult<Article>> GetArticle(String q)
        {
            var query =  _context.Articles.AsQueryable().Where(a => a.Title.Contains(q));

            if (!string.IsNullOrEmpty(q))
            {
                query = query.Where(a => a.Title.Contains(q));
                var articles = query.Select(articles => new ArticlesDTO
                {
                    Title = articles.Title,
                    Descriptions = articles.Descriptions,
                    Content = articles.Content,
                    AuthorName = articles.Author.AuthorName,
                    UlrToImage = articles.UlrToImage,
                    Ulr = articles.Ulr,
                    PublishedAt = articles.PublishedAt
                }).ToArray();

                return Ok(articles);

            }
            return NotFound();
 
        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        
        public async Task<IActionResult> PutArticle(int id, Article article)
        {
            if (id != article.ArticleId)
            {
                return BadRequest();
            }

            _context.Entry(article).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleExists(id))
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

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //[AllowAnonymous]
        //public async Task<ActionResult<Article>> PostArticle(Article article)
        //{
        //    _context.Articles.Add(article);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetArticle", new { id = article.ArticleId }, article);
        //}






        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.ArticleId == id);
        }
    }
}
