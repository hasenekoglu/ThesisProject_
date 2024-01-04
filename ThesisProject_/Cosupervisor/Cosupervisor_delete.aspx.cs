using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Cosupervisor
{
    public partial class Cosupervisor_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);    
            ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter cosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
            cosupervisor.CosupervisorDelete(id);
            Response.Redirect("/Cosupervisor/Cosupervisor_list.aspx");
        }
    }
}
