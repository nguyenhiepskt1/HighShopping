using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Models
{
    public class AppUser : IdentityUser
    {
        public string  Occupation { get; set; }
    }
}
