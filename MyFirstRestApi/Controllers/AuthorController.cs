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
    public class AuthorController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            return new Author[] {
                new Author
                {
                    Name = "Tom Lannoye"
                },
                new Author
                {
                    Name = "Herman Brusselmans"
                }
            };
        }
    }
}
