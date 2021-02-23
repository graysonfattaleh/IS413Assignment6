using System;
using System.Linq;
//basically this guy gets the info from the interface and makes a queryable variable which gets put in contxt
namespace IS413Assignment5Real.Models
{
    public class EFBooksRepository: IBooksRepository
    {
        private BookDBContext _context;

        public EFBooksRepository(BookDBContext context)
        {
            _context = context;
        }
        //put in context
        public IQueryable<Book> Books => _context.Books;
    }
}
