using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.university
{
    public partial class university_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter university = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
            university.UniversityDelete(id);
            Response.Redirect("/university/university_list.aspx");

        }
    }
}