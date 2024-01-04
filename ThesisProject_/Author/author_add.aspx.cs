using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Author
{
    public partial class author_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ThesisProject_.ThesisProjectDataTableAdapters.AUTHORSTableAdapter newAuthor = new ThesisProject_.ThesisProjectDataTableAdapters.AUTHORSTableAdapter();

            //decimal authorPhoneNumber = decimal.Parse(txtAuthorPhoneNumber.Text);
            newAuthor.AuthorAdd(txtAuthorName.Text, txtAuthorSurname.Text, txtAuthorEmail.Text);
        }
    }
}