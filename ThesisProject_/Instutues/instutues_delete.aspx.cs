using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Instutues
{
    public partial class instutues_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.INSTITUTESTableAdapter instutes = new ThesisProjectDataTableAdapters.INSTITUTESTableAdapter();
            instutes.InstutuesDelete(id);
            Response.Redirect("/Instutues/instutues_list.aspx");
        }
    }
}