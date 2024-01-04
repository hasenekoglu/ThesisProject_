using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.supervisor
{
    public partial class supervisor_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter();
            supervisor.SupervisorAdd(txtSupervisorName.Text, txtSupervisorSurname.Text, txtSupervisorEmail.Text);
            Response.Redirect("/supervisor/supervisor_list.aspx");

        }
    }
}