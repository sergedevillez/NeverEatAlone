using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NeverEatAlone.Api.Models
{
    public class LoginForm
    {
        [Required]
        [MaxLength(320)]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(320)]
        public string Password { get; set; }

    }
}
