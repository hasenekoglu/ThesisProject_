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
            if (!IsPostBack)
            {
                ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter cities = new ThesisProjectDataTableAdapters.UNIVERSITIESTableAdapter();
                TextBox1.Items.Clear();
                TextBox1.Items.Add(new ListItem("Chooose Your City"));
                TextBox1.AppendDataBoundItems = true;
                TextBox1.DataSource = cities.GetAllUniversity();
                TextBox1.DataTextField = "NAME";
                TextBox1.DataValueField = "ID";
                TextBox1.DataBind();
            }
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