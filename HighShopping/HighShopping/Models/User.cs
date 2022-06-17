using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Models
{
    public class User
    {
        [Required, MinLength(2, ErrorMessage = "Bạn phải nhập tối thiểu 2 ký tự")]
        public string UserName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Bạn phải nhập tối thiểu 4 ký tự")]
        public string Password { get; set; }
    }
}
