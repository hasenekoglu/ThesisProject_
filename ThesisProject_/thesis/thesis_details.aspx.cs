using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.thesis
{
    public partial class thesis_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.THESISTableAdapter thesis = new ThesisProjectDataTableAdapters.THESISTableAdapter();
            thesisList.DataSource = thesis.GetAllThesis();
            thesisList.DataBind();
        }
    }
}