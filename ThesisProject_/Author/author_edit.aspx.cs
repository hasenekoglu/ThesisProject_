using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThesisProject_.Author
{
    public partial class author_edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"].ToString());
                ThesisProject_.ThesisProjectDataTableAdapters.AUTHORSTableAdapter author = new ThesisProject_.ThesisProjectDataTableAdapters.AUTHORSTableAdapter();
                string authorName = author.AuthorGet(id)[0].NAME;
                string authorLastName = author.AuthorGet(id)[0].SURNAME;
                string authorEmail = author.AuthorGet(id)[0].EMAIL;

                txtAuthorName.Text = authorName;
                txtAuthorSurname.Text = authorLastName;
            
                txtAuthorEmail.Text = authorEmail;

                
                


            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ThesisProject_.ThesisProjectDataTableAdapters.AUTHORSTableAdapter author = new ThesisProject_.ThesisProjectDataTableAdapters.AUTHORSTableAdapter();
       


        }
    }
}