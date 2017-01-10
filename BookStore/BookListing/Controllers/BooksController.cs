using BookListing.DA;
using BookListing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookListing.Controllers
{
    public class BooksController : ApiController
    {
        // GET: api/Books
        public List<Book> Get()
        {
            //return new string[] { "value1", "value2" };

            BookDA bookDA = new BookDA();
            List<Book> books = bookDA.SelectBooks();

            return books;
        }

        // GET: api/Books/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Books
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Books/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Books/5
        public void Delete(int id)
        {
        }
    }
}
