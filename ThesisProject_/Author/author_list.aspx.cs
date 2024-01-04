using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Author
{
    public partial class author_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProject_.ThesisProjectDataTableAdapters.AUTHORSTableAdapter newAuthor = new ThesisProject_.ThesisProjectDataTableAdapters.AUTHORSTableAdapter();
            authorList.DataSource = newAuthor.GetAllAuthors();
            authorList.DataBind();
        }
    }
}