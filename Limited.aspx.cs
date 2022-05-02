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
    public partial class Limited : System.Web.UI.Page
    {
        public string str;
        public string status_create;
        public string status_pending;
        public string status_rejected;
        public string status_release;
        public virtual bool AllowPaging { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            update_pending();
            update_rejecting();
            update_relese();
            Details();
            status_created();
            status_pend();
            status_reject();
            status_releasing();

        }
        protected void refresh(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            Details();
        }
        protected void update_relese()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"UPDATE dbo.Change2_0
                    Set Status_ = 'Release'
                    WHERE (status1 = 'approved' AND status2 = '') OR (status1 = 'approved' and status2 = 'approved' and status3='') 
                    OR  (status1 = 'approved' and status2 = 'approved' and status3='approved' and status4 = '') 
                    OR (status1 = 'approved' and status2 = 'approved' and status3='approved' and status4 = 'approved' and status5 = '')
                    OR (status1 = 'approved' and status2 = 'approved' and status3='approved' and status4 = 'approved' and status5 = 'approved' and status6 = '')
                    OR (status1 = 'approved' and status2 = 'approved' and status3='approved' and status4 = 'approved' and status5 = 'approved' and status6 = 'approved')";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                    }
                }
            }
        }
        protected void update_rejecting()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"UPDATE dbo.Change2_0
                    Set Status_ = 'Rejected'
                    WHERE status1 = 'rejected' or status2 = 'rejected' or status3 = 'rejected' or status4 = 'rejected' or status5 = 'rejected' or status6 = 'rejected'";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                    }
                }
            }
        }
        protected void update_pending()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"UPDATE dbo.Change2_0
                    Set Status_ = 'Pending'
                    WHERE status1 = 'approved' or status2 = 'approved' or status3 = 'approved' or status4 = 'approved' or status5 = 'approved' or status6 = 'approved'";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                    }
                }
            }
        }
        public void status_created()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    
                    string sql = @"SELECT Count(*) AS Status_Created
                    FROM [dbo].[Change2_0]
                    WHERE EndDate != '' AND Status_ = 'Created';";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        status_create = Convert.ToString(dt.Rows[0]["Status_Created"]);
                        Label3.Text = status_create;
                    }
                }
            }
        }
        public void status_pend()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"SELECT Count(*) AS Status_Created
                    FROM [dbo].[Change2_0]
                    WHERE EndDate != '' AND Status_ = 'Pending';";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        status_pending = Convert.ToString(dt.Rows[0]["Status_Created"]);
                        Label5.Text = status_pending;
                    }
                }
            }
        }
        public void status_reject()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"SELECT Count(*) AS Status_Created
                    FROM [dbo].[Change2_0]
                    WHERE EndDate != '' AND Status_ = 'Rejected';";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        status_rejected = Convert.ToString(dt.Rows[0]["Status_Created"]);
                        Label7.Text = status_rejected;
                    }
                }
            }
        }
        public void status_releasing()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"SELECT Count(*) AS Status_Created
                    FROM [dbo].[Change2_0]
                    WHERE EndDate != '' AND Status_ = 'Release';";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        status_release = Convert.ToString(dt.Rows[0]["Status_Created"]);
                        Label9.Text = status_release;
                    }
                }
            }
        }
        public void Details()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = @"SELECT [ID]
                                  ,[Created_By]
                                  ,[StartDate]
                                  ,[EndDate]
                                  ,[Poms_Art]
                                  ,[Quantity]
                                  ,[department]
                                  ,[machine]
                                  ,[code]
                                  ,[Status_]
                                  
                              FROM [dbo].[Change2_0]
                              Where [EndDate] != ''
                              ORDER By [ID] DESC;
                              ";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.AllowPaging = true;
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
        }

        public void Details_sort(object sender, GridViewSortEventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = @"SELECT [ID]
                                  ,[Created_By]
                                  ,[StartDate]
                                  ,[EndDate]
                                  ,[Poms_Art]
                                  ,[Quantity]
                                  ,[department]
                                  ,[machine]
                                  ,[code]
                                  ,[Status_]
                                  
                              FROM [dbo].[Change2_0]
                              Where [EndDate] != '';";

                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dt.DefaultView.Sort = e.SortExpression;
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }

        }
        protected void GrdEmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
        public void search(object sender, EventArgs e)
        {
            str = TextBox1.Text;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = @"SELECT [ID]
                                  ,[Created_By]
                                  ,[StartDate]
                                  ,[EndDate]
                                  ,[Poms_Art]
                                  ,[Quantity]
                                  ,[department]
                                  ,[machine]
                                  ,[code]
                                  ,[Status_]
                                  FROM [dbo].[Change2_0]
                                 Where ([EndDate] != '') AND ( [ID]Like '%" + str + @"%' OR [Created_By] LIKE '%" + str + @"%' 
                                OR [StartDate] LIKE '%" + str + @"%' 
                                OR [EndDate] LIKE '%" + str + @"%'
                                OR [Quantity] LIKE '%" + str + @"%' 
                                OR [department] LIKE  '%" + str + @"%'
                                OR [machine] LIKE '%" + str + @"%' 
                                OR [code] LIKE '%" + str + @"%' 
                                OR [Status_] LIKE '%" + str + @"%')";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.AllowPaging = false;
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            TextBox1.Text = "";
        }
        protected void RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            int id = (int)GridView1.DataKeys[row.RowIndex].Values["ID"];
            Label delete = (Label)row.FindControl("delete");
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = @"delete FROM [dbo].[Change2_0] where id = '" + id + "'";

                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.AllowPaging = false;
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            Details();
            status_created();
            status_pend();
            status_reject();
            status_releasing();
        }
        protected void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    GridViewRow row1 = (GridViewRow)GridView1.Rows[row.RowIndex];
                    int id = (int)GridView1.DataKeys[row1.RowIndex].Values["ID"];


                    string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            string sql = @"select [ID]
                                           ,[Created_By]
                                          ,[StartDate]
                                          ,[EndDate]
                                          ,[Poms_Art]
                                          ,[Quantity]
                                          ,[Main_Condition]
                                          ,[Other_Condition]
                                          ,[Deviation_Cond]
                                          ,[Action_Plan]
                                          ,[Special_Inst]
                                          ,[Status_]
                                          ,[department]
                                          ,[machine]
                                          ,[code]
                                          ,[approval1]
                                          ,[status1]
                                          ,[approval2]
                                          ,[status2]
                                          ,[approval3]
                                          ,[status3]
                                          ,[approval4]
                                          ,[status4]
                                          ,[approval5]
                                          ,[status5]
                                          ,[approval6]
                                          ,[status6]
                                          ,[informer1]
                                          ,[informer2]
                                          ,[informer3]
                                          ,[informer4]
                                          ,[informer5]
                                          ,[informer6]
                            FROM [dbo].[Change2_0] where id = '" + id + "' ";

                            cmd.CommandText = sql;
                            cmd.Connection = con;
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                Session["numberA"] = Convert.ToString(dt.Rows[0]["ID"]);
                                Session["createA"] = Convert.ToString(dt.Rows[0]["Created_By"]);
                                Session["startA"] = Convert.ToString(dt.Rows[0]["StartDate"]);
                                Session["endA"] = Convert.ToString(dt.Rows[0]["EndDate"]);
                                Session["pomsA"] = Convert.ToString(dt.Rows[0]["Poms_Art"]);
                                Session["departmentA"] = Convert.ToString(dt.Rows[0]["department"]);
                                Session["masinaA"] = Convert.ToString(dt.Rows[0]["machine"]);
                                Session["codeA"] = Convert.ToString(dt.Rows[0]["code"]);
                                Session["quantityA"] = Convert.ToString(dt.Rows[0]["Quantity"]);
                                Session["conditionA"]= Convert.ToString(dt.Rows[0]["Main_Condition"]);
                               // ApprovalList.others = Convert.ToString(dt.Rows[0]["Other_Condition"]);
                                Session["cerereA"] = Convert.ToString(dt.Rows[0]["Deviation_Cond"]);
                                Session["actionA"] = Convert.ToString(dt.Rows[0]["Action_Plan"]);
                                Session["instrA"] = Convert.ToString(dt.Rows[0]["Special_Inst"]);
                                Session["statusA"] = Convert.ToString(dt.Rows[0]["Status_"]);
                                Session["approval1A"] = Convert.ToString(dt.Rows[0]["approval1"]);
                                Session["approval2A"] = Convert.ToString(dt.Rows[0]["approval2"]);
                                Session["approval3A"] = Convert.ToString(dt.Rows[0]["approval3"]);
                                Session["approval4A"] = Convert.ToString(dt.Rows[0]["approval4"]);
                                Session["approval5A"] = Convert.ToString(dt.Rows[0]["approval5"]);
                                Session["approval6A"] = Convert.ToString(dt.Rows[0]["approval6"]);
                                Session["informer1A"] = Convert.ToString(dt.Rows[0]["informer1"]);
                                Session["informer2A"] = Convert.ToString(dt.Rows[0]["informer2"]);
                                Session["informer3A"] = Convert.ToString(dt.Rows[0]["informer3"]);
                                Session["informer4A"] = Convert.ToString(dt.Rows[0]["informer4"]);
                                Session["informer5A"] = Convert.ToString(dt.Rows[0]["informer5"]);
                                Session["informer6A"] = Convert.ToString(dt.Rows[0]["informer6"]);
                                Session["status1A"] = Convert.ToString(dt.Rows[0]["status1"]);
                                Session["status2A"] = Convert.ToString(dt.Rows[0]["status2"]);
                                Session["status3A"] = Convert.ToString(dt.Rows[0]["status3"]);
                                Session["status4A"] = Convert.ToString(dt.Rows[0]["status4"]);
                                Session["status5A"] = Convert.ToString(dt.Rows[0]["status5"]);
                                Session["status6A"] = Convert.ToString(dt.Rows[0]["status6"]);
                            }
                        }
                    }
                    Response.Redirect("ApprovalList1.aspx");
                }
            }
        }
    }
}