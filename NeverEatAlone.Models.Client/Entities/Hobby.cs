using System;
using System.Collections.Generic;
using System.Text;

namespace NeverEatAlone.Models.Client.Entities
{
    public class Hobby
    {
        public int HobbyId { get; private set; }
        public string HobbyName { get; private set;}

        public Hobby(string hobbyName)
        {
            HobbyName = hobbyName;
        }

        internal Hobby(int hobbyId, string hobbyName)
            : this(hobbyName)
        {
            HobbyId = hobbyId;
        }
    }
}
