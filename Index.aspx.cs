using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeTool2._0
{
    public partial class Index : System.Web.UI.Page
    {
       
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            framestyle.Attributes["src"] = "Create.aspx";
        }
        protected void OnClick1(object sender,EventArgs e)
        {
            framestyle.Attributes["src"] = "Limited.aspx";
        }
        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            framestyle.Attributes["src"] = "Limited.aspx";
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            framestyle.Attributes["src"] = "MyCreate.aspx";
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            framestyle.Attributes["src"] = "ApprovalList.aspx";
        }
        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        protected void click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Response.Redirect("Default.aspx");
        }
    }
}