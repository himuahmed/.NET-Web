using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInformationKeeper.DAL;
using BookInformationKeeper.Models;

namespace BookInformationKeeper.BLL
{
    public class booksManager
    {
        booksGateway booksgateway = new booksGateway();

        public string saveBooks(Books book)
        {
            bool checkInsertion = booksgateway.insertBooks(book);
            if (checkInsertion)
            {
                return "Saved successfully";
            }
            else
            {
                return "Failed to save";
            }
        }

        public List<Books> showBooks(Books book)
        {

            return booksgateway.fetchBooks(book);
        }

        public List<Books> showAllBooks(Books book)
        {
            return booksgateway.getAllBooks(book);
        }

        public List<Books> showSearchedBooks(Books book)
        {
           return booksgateway.fetchBooks(book);
        }
    }
}