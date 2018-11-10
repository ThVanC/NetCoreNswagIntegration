using Microsoft.AspNetCore.Mvc;
using MyFirstRestApi.Contract.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstRestApi.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return new Book[] {
                new Book
                {
                    Id = 1,
                    Author = new Author
                    {
                        Name = "Tom Lannoye"
                    },
                    Description = "His first book",
                    Title = "Title of the book"
                },
                new Book
                {
                    Id = 2,
                    Author = new Author
                    {
                        Name = "Herman Brusselmans"
                    },
                    Description = "His second book",
                    Title = "Title of his second book"
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            switch (id)
            {
                case 1:
                    return new Book
                    {
                        Id = 1,
                        Author = new Author
                        {
                            Name = "Tom Lannoye"
                        },
                        Description = "His first book",
                        Title = "Title of the book"
                    };
                case 2:
                    return new Book
                    {
                        Id = 2,
                        Author = new Author
                        {
                            Name = "Herman Brusselmans"
                        },
                        Description = "His second book",
                        Title = "Title of his second book"
                    };
                default:
                    return null;
            }
        }
    }
}
