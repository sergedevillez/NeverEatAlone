using NeverEatAlone.Models.Common.Interfaces;
using NeverEatAlone.Models.Client.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Client.Entities
{
    public class User
    {
        public int UserId { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string IdPhoto { get; private set; }

        public User(string lastName, string firstName, string email, string password, string idPhoto)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            IdPhoto = idPhoto;
        }

        internal User(int userId, string firstName, string lastName, string email, string idPhoto)
            : this(firstName, lastName, email, null, idPhoto)
        {
            UserId = userId;
        }

    }
}
