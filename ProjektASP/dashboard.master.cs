using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjektASP
{
    public partial class dashboard : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["UserName"] == null) {
               Response.Redirect("~/Login.aspx");
           } else {
                dbLabel.Text = "Elo " + Session["UserName"].ToString() + " !";
           }
        }
    }
}