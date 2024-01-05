using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.thesis
{
    public partial class thesis_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();
            thesis.ThesisDelete(id);
            Response.Redirect("/thesis/thesis_list.aspx");
        }
    }
}