using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThesisProject_.instutues;
using ThesisProject_.Instutues;

namespace ThesisProject_.instutues
{
    public partial class instutues_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.INSTITUTESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTITUTESTableAdapter();

            instutuesList.DataSource = instutues.GetAllInstutues();
            instutuesList.DataBind();
        }
    }
}