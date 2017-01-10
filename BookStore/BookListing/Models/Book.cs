using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookListing.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public String BookName { get; set; }
        public String BookAuthor { get; set; }
        public float Price { get; set; }
    }
}