using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.userViews
{
    public partial class user_supervisor_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter();
            supervisorList.DataSource = supervisor.GetAllSupervisor();
            supervisorList.DataBind();


        }
    }
}