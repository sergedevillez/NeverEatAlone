using NeverEatAlone.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeverEatAlone.Api.Models
{
    public class ApiUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string IdPhoto { get; set; }
    
        public ApiUser(User user)
        {
            UserId = user.UserId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            IdPhoto = user.IdPhoto;
        }

        public ApiUser(int userId, string firstName, string lastName, string email, string idPhoto)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IdPhoto = idPhoto;
        }
    }
}
