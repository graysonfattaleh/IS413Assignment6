using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413Assignment5Real.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author First Name Required")]
        public string AuthorFirst { get; set; }
        public string AuthorMiddle { get; set; }
        [Required(ErrorMessage = "Author Last Required")]
        public string AuthorLast { get; set; }
        [Required(ErrorMessage = "Publisher Required")]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "ISBN Required")]
        [RegularExpression("^[0-9]{3}(?:-[0-9]{10})?$",ErrorMessage = ("invalid ISBN NUmber"))]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Classification Required")]
        public string Classification { get; set; }
        [Required(ErrorMessage = "Category Required")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Price Required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Pages Required")]
        public double Pages { get; set; }



    }
}
