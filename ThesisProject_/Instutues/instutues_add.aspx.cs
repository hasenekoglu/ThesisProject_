using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Instutues
{
    public partial class instutues_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
           
           ThesisProjectDataTableAdapters.INSTITUTESTableAdapter instutues = new ThesisProjectDataTableAdapters.INSTITUTESTableAdapter();
          int ID = Convert.ToInt32(TextBox1.Text);
            instutues.InstutuesAdd(txtInstues.Text,ID);
      //buraya dropdown eklenecek 
            Response.Redirect("/Instutues/instutues_list.aspx");
        }
    }
}