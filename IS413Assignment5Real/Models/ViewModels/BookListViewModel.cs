using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
namespace IS413Assignment5Real.Models.ViewModels
{
    public class BookListViewModel
    {


        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }

    }
}
