using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Cosupervisor
{
    public partial class Cosupervisor_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter cosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
            Cosupervisorlist.DataSource = cosupervisor.GetAllSupervisor();
            Cosupervisorlist.DataBind();
        }
    }
}