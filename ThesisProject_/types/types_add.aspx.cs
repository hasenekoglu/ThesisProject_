using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.types
{
    public partial class types_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.TYPESTableAdapter type = new ThesisProjectDataTableAdapters.TYPESTableAdapter();
            type.TypeAdd(txtType.Text);  
            Response.Redirect("/types/types_list.aspx");
        }
    }
}