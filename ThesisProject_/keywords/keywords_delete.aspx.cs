using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.keywords
{
    public partial class keywords_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.KEYWORDSTableAdapter keyword = new ThesisProjectDataTableAdapters.KEYWORDSTableAdapter();
            keyword.KeywordDelete(id);
            Response.Redirect("/keywords/keywords_list.aspx");
        }
    }
}