using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeTool2._0
{
    public partial class ApprovalList1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label31.Text = "Raport derogare numarul:" + Session["numberA"];
            Label2.Text = (string)Session["numberA"];
            Label4.Text = (string)Session["createA"];
            Label6.Text = (string)Session["startA"];
            Label8.Text = (string)Session["endA"];
            Label10.Text = (string)Session["pomsA"];
            Label12.Text = (string)Session["departmentA"];
            Label14.Text = (string)Session["masinaA"];
            Label16.Text = (string)Session["codeA"];
            Label30.Text = (string)Session["quantityA"];
            Label18.Text = (string)Session["conditionA"];
            //Label32.Text = ApprovalList.others;
            Label20.Text = (string)Session["cerereA"];
            Label22.Text = (string)Session["actionA"];
            Label24.Text = (string)Session["instrA"];

            Label26.Text = (string)Session["approval1A"] + "-" + (string)Session["status1A"] + " " + (string)Session["approval2A"] +
                "-" + (string)Session["status2A"] + "</br>" + (string)Session["approval3A"] + "-" + (string)Session["status3A"]
                + " " + (string)Session["approval4A"] + "-" + (string)Session["status4A"] + "</br>" + (string)Session["approval5A"] + "-" + (string)Session["status5A"]
                + " " + (string)Session["approval6A"] + "-" + (string)Session["status6A"];
            Label28.Text = " " + (string)Session["informer1A"] + " " + (string)Session["informer2A"] + " " + (string)Session["informer3A"] + "<br/>" +
                " " + (string)Session["informer4A"] + " " + (string)Session["informer5A"] + " " + (string)Session["informer6A"] + " ";
            if((string)Session["statusA"] == "Release")
            {
                print.Visible = true;
            }
            else
            {
                print.Visible = false;  
            }
        }
    }
}