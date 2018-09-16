using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Dtos
{
    public class UserForLoginDto
    {
        [Required]
        public String Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
