using BookListing.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace BookListing.DA
{
    public class BookDA : SQLiteDB
    {

        public List<Book> SelectBooks()
        {

            String sql = "Select * from Books";

            List<Book> books = new List<Book>();

            DataTable dt = GetDataTable(sql);

            foreach (DataRow row in dt.Rows)
            {
                Book book = new Models.Book();

                book.BookId = Convert.ToInt32(row["BookId"]);
                book.BookName = row["BookName"].ToString();

                books.Add(book);
            }

            return books;

        }
    }
}