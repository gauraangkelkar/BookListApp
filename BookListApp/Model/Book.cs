using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListApp.Model
{
    public class Book
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String Title { get; set; }
        public String AuthorName { get; set; }
        public float Price { get; set; }
    }
}
