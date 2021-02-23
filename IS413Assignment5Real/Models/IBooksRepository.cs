using System;
using System.Linq;
//basically this guy gets the info about books from the db and makes it an interface
namespace IS413Assignment5Real.Models
{
    public interface IBooksRepository
    {
        IQueryable<Book> Books { get; }
    }
}
