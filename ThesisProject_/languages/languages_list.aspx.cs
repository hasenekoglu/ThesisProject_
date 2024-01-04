using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.languages
{
    public partial class languages__list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.LANGUAGESTableAdapter language = new ThesisProjectDataTableAdapters.LANGUAGESTableAdapter();
            languagesList.DataSource = language.GetAllLanguages();
            languagesList.DataBind();
        }
    }
}