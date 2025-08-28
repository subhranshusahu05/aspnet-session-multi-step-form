using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FamilyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetails"] == null) { Response.Redirect("PersonalDetails.aspx"); }
            else { txtspous.Focus(); }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["UserDetails"] != null)
            {    //in this coed here NEW is not added as we are not creating a new dictionary we just add this section to the existing dictionary
                Dictionary<string, string> Details = (Dictionary<string, string>)Session["UserDetails"];
                Details.Add("Spouse Name", txtspous.Text);
                Details.Add("Mother Name", txtmother.Text);
                Session["UserDetails"] = Details;
                Response.Redirect("DisplayDetails.aspx");
            }
            else { Response.Redirect("PersonalDetails.aspx"); }
        }
    }
}