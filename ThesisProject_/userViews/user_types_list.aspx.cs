using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.userViews
{
    public partial class user_types_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.TYPESTableAdapter type = new ThesisProjectDataTableAdapters.TYPESTableAdapter();
            typeList.DataSource = type.GetAllTypes();
            typeList.DataBind();
        }
    }
}