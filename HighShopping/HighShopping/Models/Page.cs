using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Models
{
    public class Page
    {       
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Bạn phải nhập tối thiểu 2 ký tự")]
        public string Title { get; set; }  
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Bạn phải nhập tối thiểu 4 ký tự")]
        public string Content { get; set; }   
        public int Sorting { get; set; }
    }
}
