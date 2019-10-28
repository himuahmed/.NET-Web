using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInformationKeeper.BLL;
using BookInformationKeeper.Models;

namespace BookInformationKeeper
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                    
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string bookName = nameID.Value;
            string isbn = isbnID.Value;
            string author = authorID.Value;

            Books book = new Books(bookName, isbn, author);

            booksManager aBook = new booksManager();
            if (aBook.saveBooks(book) == "Saved successfully")
            {
                saveButtonLabel.ForeColor = Color.Green;
            }
            else
            {
                saveButtonLabel.Text = "Failed to save";
                saveButtonLabel.ForeColor = Color.Red;
            }

        }

        
    }
}