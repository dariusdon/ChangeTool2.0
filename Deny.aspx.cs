using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeTool2._0
{
    public partial class Deny : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = (string)Session["numberA"];
            Label4.Text = (string)Session["numberA"];
        }
        protected void OnClick(object sender, EventArgs e)
        {
            Response.Redirect("ApprovalList.aspx");
        }
    }
}