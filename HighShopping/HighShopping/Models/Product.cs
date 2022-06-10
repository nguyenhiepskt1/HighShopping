using HighShopping.Infrastructure;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MinLength(2, ErrorMessage = "Bạn phải nhập tối thiểu 2 ký tự")]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required, MinLength(4, ErrorMessage = "Bạn phải nhập tối thiểu 4 ký tự")]
        public string Description { get; set; }
        public float Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Hãy chọn danh mục cho sản phẩm")]
        public int CategoryId { get; set; }      
        public string Image { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [NotMapped]
        public IFormFile ImageUpload { get; set; }
    }
}
