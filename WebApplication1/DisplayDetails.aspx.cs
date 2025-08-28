using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DisplayDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserDetails"] != null)
            {
                Dictionary<string, string> Details = (Dictionary<string, string>)Session["UserDetails"];
                foreach (string Key in Details.Keys) { Response.Write(Key + ": " + Details[Key] + "<br />"); }
            }
            else { Response.Redirect("PersonalDetails.aspx"); }
        }
    }
}