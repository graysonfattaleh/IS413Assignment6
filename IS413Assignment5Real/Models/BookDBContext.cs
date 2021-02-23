using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//this guy makes a context that inherits from db context specifically for our book set

namespace IS413Assignment5Real.Models
{
    public class BookDBContext : DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        {

        }
        //this makes a queryable set of type book that can give info to our repository classes

        public DbSet<Book> Books { get; set; }
    }
}


