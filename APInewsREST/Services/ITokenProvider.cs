using APInewsREST.Models;
using Microsoft.IdentityModel.Tokens;
using System;

namespace APInewsREST.Services
{
    public interface ITokenProvider
    {
        string CreateToken(Users user, DateTime expirationDate);
        TokenValidationParameters GetValidationParameters();
    }
}