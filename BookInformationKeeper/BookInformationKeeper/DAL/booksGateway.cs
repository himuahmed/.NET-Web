using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookInformationKeeper.Models;

namespace BookInformationKeeper.DAL
{
    public class booksGateway
    {
        public bool insertBooks(Books book)
        {
            string connectioString = @"Server=PC-301-13\SQLEXPRESS;Database=BookInformationDB;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectioString);

            if (book.Isbn.Length <= 13)
            {

                string query = "INSERT INTO books_tbl(bookName,isbn,author) VALUES('" + book.BookName + "','" +
                               book.Isbn + "','" + book.Author + "')";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int isRowEffect = command.ExecuteNonQuery();
                connection.Close();

                if (isRowEffect > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }


        }

        public List<Books> fetchBooks(Books book)
        {
            List<Books> bookList1 = new List<Books>();
            string connectionString1 =
                @"Server=PC-301-13\SQLEXPRESS;Database=BookInformationDB;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString1);

            string query = "SELECT * books_tbl WHERE bookName = '" + book.BookName + "'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Books abook = null;

            while (reader.Read())
            {
                abook = new Books();
                abook.BookId = Int32.Parse(reader["bookId"].ToString());
                abook.BookName = reader["bookName"].ToString();
                abook.Isbn = reader["isbn"].ToString();
                abook.Author = reader["author"].ToString();
                bookList1.Add(abook);
            }
            reader.Close();
            connection.Close();
            return bookList1;

        }

        public List<Books> getAllBooks(Books book)
        {
          List<Books> bookList2 = new List<Books>();

            string connectionString1 = @"Server=PC-301-13\SQLEXPRESS;Database=BookInformationDB;Integrated Security=true";
            SqlConnection connection = new SqlConnection(connectionString1);

            string query = "SELECT * books_tbl";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Books abook = null;

            while (reader.Read())
            {
                abook = new Books();
                abook.BookId = Int32.Parse(reader["bookId"].ToString());
                abook.BookName = reader["bookName"].ToString();
                abook.Isbn = reader["isbn"].ToString();
                abook.Author = reader["author"].ToString();
                bookList2.Add(abook);
            }

            reader.Close();
            connection.Close();
            return bookList2;
        }
    }
}