using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInformationKeeper.BLL;
using BookInformationKeeper.Models;

namespace BookInformationKeeper
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string name = searchNameID.Value;   
            Books book = new Books(name);

            booksManager aBook = new booksManager();
            if (name.Length != null)
            {
                aBook.showSearchedBooks(book);
            }
            else
            {
                aBook.showAllBooks(book);
            }
        }
    }
}