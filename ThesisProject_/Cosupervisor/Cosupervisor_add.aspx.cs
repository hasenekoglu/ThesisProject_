using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Cosupervisor
{
    public partial class Cosupervisor_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter newcosupervisor = new ThesisProjectDataTableAdapters.COSUPERVISORTableAdapter();
            newcosupervisor.CosupervisorAdd(txtCosupervisorName.Text,txtCosupervisorSurname.Text,txtCosupervisorEmail.Text);
            Response.Redirect("/Cosupervisor/Cosupervisor_list.aspx");

        }
    }
}