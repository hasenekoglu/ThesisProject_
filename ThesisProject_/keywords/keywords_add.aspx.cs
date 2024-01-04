using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.keywords
{
    public partial class keywords_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.KEYWORDSTableAdapter keyword= new ThesisProjectDataTableAdapters.KEYWORDSTableAdapter();
            keyword.KeywordAdd(txtKeyword.Text);
            Response.Redirect("/keywords/keywords_list.aspx");
        }
    }
}