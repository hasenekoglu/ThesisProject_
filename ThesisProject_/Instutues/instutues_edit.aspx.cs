using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Instutues
{
    public partial class instutues_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ThesisProjectDataTableAdapters.INSTITUTESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTITUTESTableAdapter();
                string instutueName = instutues.GetInstutues(id)[0].INSTUTUE;
                
                txtInstutue.Text = instutueName;
            }
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProjectDataTableAdapters.INSTITUTESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTITUTESTableAdapter();
            instutues.InstutuesUpdate(txtInstutue.Text, id,id);
            Response.Redirect("/Instutues/instutues_list.aspx");

        }
    }
}