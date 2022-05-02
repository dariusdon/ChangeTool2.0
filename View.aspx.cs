using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Collections;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Configuration;

namespace ChangeTool2._0
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label33.Text = "Raport derogare numarul:" + ApprovalList.number;
            Label2.Text = ApprovalList.number;
            Label4.Text = ApprovalList.create;
            Label6.Text = ApprovalList.start;
            Label8.Text = ApprovalList.end;
            Label10.Text = ApprovalList.poms;
            Label12.Text = ApprovalList.department;
            Label14.Text = ApprovalList.masina;
            Label16.Text = ApprovalList.code;
            Label30.Text = ApprovalList.cantitate;
            Label18.Text = ApprovalList.conditii;
            Label32.Text = ApprovalList.others;
            Label20.Text = ApprovalList.cerere;
            Label22.Text = ApprovalList.action;
            Label24.Text = ApprovalList.instructiuni;
            Label26.Text = ApprovalList.approval1 + " Status:" + ApprovalList.status1 + "<br/>" + ApprovalList.approval2 +
                " Status:" + ApprovalList.status2 + "<br/>" + ApprovalList.approval3 + " Status:" + ApprovalList.status3
                + "<br/>" + ApprovalList.approval4 + " Status:" + ApprovalList.status4 + "<br/>" + ApprovalList.approval5 + " Status:" + ApprovalList.status5
                + "<br/>" + ApprovalList.approval6 + " Status:" + ApprovalList.status6;
            Label28.Text = " " + ApprovalList.informer1 + " " + ApprovalList.informer2 + " " + ApprovalList.informer3 + "<br/>" +
                " " + ApprovalList.informer4 + " " + ApprovalList.informer5 + " " + ApprovalList.informer6 + "<br/>";
            if (ApprovalList.status == "Release")
            {
                print.Visible = true;
                Label34.Visible = false;
                Label35.Visible = false;
            }
            if (ApprovalList.status == "Pending")
            {
                print.Visible = false;
                Label34.Visible = false;
                Label35.Visible = false;
            }

            if (ApprovalList.status == "Created")
            {
                print.Visible = false;
                Label34.Visible = false;
                Label35.Visible = false;
            }

            if (ApprovalList.status == "Rejected")
                {
                    string motiv;
                    Label34.Visible = true;
                    Label35.Visible = true;
                    string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            string sql = @"Select motiv from dbo.change2_0
                            where ID = '"+ApprovalList.number+"';";
                            cmd.CommandText = sql;
                            cmd.Connection = con;
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                motiv = Convert.ToString(dt.Rows[0]["motiv"]);
                            }
                        }
                    }
                    Label35.Text = motiv;
                    print.Visible = false;
                }
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}