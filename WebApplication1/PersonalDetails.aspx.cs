using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class PersonalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Details = new Dictionary<string, string>();
            Details.Add("First Name", TextBox1.Text);
            Details.Add("Last Name", TextBox2.Text);
            Details.Add("Email", TextBox3.Text);
            Details.Add("Phone", TextBox4.Text);
            Session["UserDetails"] = Details;
            Response.Redirect("FamilyDetails.aspx");
        }
    }
}