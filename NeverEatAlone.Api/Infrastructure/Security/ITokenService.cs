using NeverEatAlone.Api.Models;
using NeverEatAlone.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeverEatAlone.Api.Infrastructure.Security
{
    public interface ITokenService
    {
        string GenerateToken(User user);
        ApiUser ValidateToken(string token);
    }
}
