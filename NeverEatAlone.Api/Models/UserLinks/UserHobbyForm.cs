using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NeverEatAlone.Api.Models.UserLinks
{
    public class UserHobbyForm
    {

        [Required]
        public int UserInt { get; set; }

        //Todo : Make hobbyInt a table []
        [Required]
        public int HobbyInt { get; set; }
    }
}
