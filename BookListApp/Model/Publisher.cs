using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListApp.Model
{
    public class Publisher
    {
        [Key]
        public int id { get; set; }
        [Required]
        public String Publisher_Name { get; set; }
        public String Publisher_Address { get; set; }
    }
}
