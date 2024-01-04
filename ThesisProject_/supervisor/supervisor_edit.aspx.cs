using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.supervisor
{
    public partial class supervisor_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter supervisor =  new ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter();
            string supervisorName = supervisor.SupervisorGet(id)[0].NAME;
            string supervisorSurname = supervisor.SupervisorGet(id)[0].SURNAME;
          
            string supervisorEmail = supervisor.SupervisorGet(id)[0].EMAIL;

            txtSupervisorName.Text = supervisorName;
            txtSupervisorSurname.Text = supervisorSurname;
        
            txtSupervisorEmail.Text = supervisorEmail;

            }

        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter supervisor = new ThesisProjectDataTableAdapters.SUPERVISORSTableAdapter();
            supervisor.SupervisorUpdate(txtSupervisorName.Text, txtSupervisorSurname.Text, txtSupervisorEmail.Text, id);
            Response.Redirect("/supervisor/supervisor_list.aspx");

        }
    }
}