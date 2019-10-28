using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInformationKeeper.Models
{

    public class Books
    {
        public int BookId { set; get; }
        public string BookName { set; get; }
        public string Isbn { set; get; }
        public string Author { set; get; }
        public Books(int bookId, string bookName, string isbn, string author)
        {
            BookId = bookId;
            BookName = bookName;
            Isbn = isbn;
            Author = author;
        }
        
        public Books(string bookName, string isbn, string author)
        {
            this.BookName = bookName;
            Isbn = isbn;
            Author = author;
        }

        public Books()
        {
        }

        public Books(string bookName)
        {
            BookName = bookName;
        }
    }
}