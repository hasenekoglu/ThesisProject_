using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.keywordsofthesis
{
    public partial class keywords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThesisProjectDataTableAdapters.KEYWORDSOFTHESISTableAdapter keyword = new ThesisProjectDataTableAdapters.KEYWORDSOFTHESISTableAdapter();
            keywordsofthesis.DataSource = keyword.GetAllKeywords();
            keywordsofthesis.DataBind();
        }
    }
}