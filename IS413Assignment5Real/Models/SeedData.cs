using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace IS413Assignment5Real.Models
{

   
    public class SeedData
    {
        // method to generate default recourds
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            // makes context variable from create scope guy which is also in start up
            BookDBContext context = application.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<BookDBContext>();

            // checks to see if any migrations are needed and makes them
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            // if there arent any books itll add the ones listed below.
            if (!context.Books.Any())
            {
                context.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorMiddle = "",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        Pages = 1488
                    },
                    new Book
                    {
                        Title = "Team Of Rivals",
                        AuthorFirst = "Doris",
                        AuthorMiddle = "Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        Pages = 944
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorMiddle = "",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0552284611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        Pages = 832
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        AuthorMiddle = "C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        Pages = 864
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorMiddle = "",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 13.33,
                        Pages = 528
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        Pages = 288
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorMiddle = "",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        Pages = 304
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorMiddle = "",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        Pages = 240
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorMiddle = "",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        Pages = 400
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorMiddle = "",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        Pages = 642
                    },

                new Book
                {
                    Title = "The Little Prince",
                    AuthorFirst = " Antoine",
                    AuthorMiddle = "de",
                    AuthorLast = "Saint-Expurey",
                    Publisher = "Reynal & Hitchcock",
                    ISBN = "	978-0140188028",
                    Classification = "Fiction",
                    Category = "Fantasy",
                    Price = 11.12,
                    Pages = 88
                },

                new Book
                {
                    Title = "The Great Gatsby",
                    AuthorFirst = "Francis",
                    AuthorMiddle = "Scott",
                    AuthorLast = "Fitzgerald",
                    Publisher = "Perkins",
                    ISBN = "978-0910457057",
                    Classification = "Fiction",
                    Category = "Drama",
                    Price = 9.03,
                    Pages = 167
                },

                new Book
                {
                    Title = "Believing Christ",
                    AuthorFirst = "Stephen",
                    AuthorMiddle = "E",
                    AuthorLast = "Robinson",
                    Publisher = "Bookcraft Pubs",
                    ISBN = "978-0875798073",
                    Classification = "Non-Fiction",
                    Category = "Religous",
                    Price = 15.03,
                    Pages = 125
                });
            }
            // saves stuff added to context like all the new books
            context.SaveChanges();
        }
    }
}
