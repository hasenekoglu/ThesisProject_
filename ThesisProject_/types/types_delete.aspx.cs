using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.types
{
    public partial class types_delete_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);    
                ThesisProjectDataTableAdapters.TYPESTableAdapter type = new ThesisProjectDataTableAdapters.TYPESTableAdapter();
                type.TypeDelete(id);
                Response.Redirect("/types/types_list.aspx");
            }
        }
    }
}