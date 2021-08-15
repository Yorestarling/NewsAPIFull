using APInewsREST.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using APInewsREST.Models;
using Microsoft.AspNetCore.Authorization;
using APInewsREST.Services;

namespace APInewsREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly NewsAPIsideContext context;
        private readonly ITokenProvider tokenProvider;

        public AccountController(NewsAPIsideContext context, ITokenProvider tokenProvider)
        {
            this.context = context;
            this.tokenProvider = tokenProvider;
        }

        [HttpPost("auth")]
       [AllowAnonymous]
        public IActionResult Authenticate([FromForm] string username, [FromForm] string password)
        {
            var connection = context.Database.GetDbConnection();

            var result = connection.QuerySingleOrDefault<Users>("UsersValidate", new { username, password }, commandType: System.Data.CommandType.StoredProcedure);

            if (result == null)
            {
                return BadRequest("Invalid credentials.");
            }

            int expirationInHour = 24;

            DateTime expiratiorn = DateTime.UtcNow.AddHours(expirationInHour);

            var token = tokenProvider.CreateToken(result, expiratiorn);

            return Ok(new
            {
                token = token,
                expires_in = expirationInHour * 60 * 60
            });
        }
    }
}
