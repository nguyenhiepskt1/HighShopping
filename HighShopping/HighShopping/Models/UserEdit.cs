using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Models
{
    public class UserEdit
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), MinLength(4, ErrorMessage = "Bạn phải nhập tối thiểu 4 ký tự")]
        public string Password { get; set; }

        public UserEdit() { }

        public UserEdit(AppUser appUser)
        {
            Email = appUser.Email;
            Password = appUser.PasswordHash;
        }
    }
}
