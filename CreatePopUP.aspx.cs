using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeTool2._0
{
    public partial class CreatePopUP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Convert.ToString(Session["index2"]);
            Label4.Text = Convert.ToString(Session["index2"]);
        }
        protected void OnClick(object sender,EventArgs e)
        {
            Response.Redirect("User.aspx");
        }
    }
}