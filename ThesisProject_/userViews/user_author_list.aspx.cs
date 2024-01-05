using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.userViews
{
    public partial class user_author_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.AUTHORSTableAdapter author = new ThesisProjectDataTableAdapters.AUTHORSTableAdapter();
            authorList.DataSource = author.GetAllAuthors();
            authorList.DataBind();
        }
    }
}