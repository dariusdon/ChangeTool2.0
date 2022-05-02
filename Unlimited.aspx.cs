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
    public partial class Unlimited : System.Web.UI.Page
    {
        public string str;
        public string status_create;
        public string status_pending;
        public string status_rejected;
        public string status_release;
        public virtual bool AllowPaging { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
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

        public void status_created()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"SELECT Count(*) AS Status_Created
                    FROM [dbo].[Change2_0]
                    WHERE EndDate = '' AND Status_ = 'Created';";
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
                    WHERE EndDate = '' AND Status_ = 'Pending';";
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
                    WHERE EndDate = '' AND Status_ = 'Rejected';";
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
                    WHERE EndDate = '' AND Status_ = 'Release';";
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
                                  ,[Poms_Art]
                                  ,[Quantity]
                                  ,[department]
                                  ,[machine]
                                  ,[code]
                                  ,[Status_]
                                  
                              FROM [dbo].[Change2_0]
                              Where [EndDate] = ''
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
                                  ,[Poms_Art]
                                  ,[Quantity]
                                  ,[department]
                                  ,[machine]
                                  ,[code]
                                  ,[Status_]
                                  
                              FROM [dbo].[Change2_0]
                              Where [EndDate] = '';";
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
            string str = TextBox1.Text;
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
                              Where ([EndDate] = '') AND ( [Created_By] LIKE '%" + str + @"%' 
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
                                          ,[informer1]
                                          ,[informer2]
                                          ,[informer3]
                            FROM [dbo].[Change2_0] where id = '" + id + "'";

                            cmd.CommandText = sql;
                            cmd.Connection = con;
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                ApprovalList.number = Convert.ToString(dt.Rows[0]["ID"]);
                                ApprovalList.create = Convert.ToString(dt.Rows[0]["Created_By"]);
                                ApprovalList.start = Convert.ToString(dt.Rows[0]["StartDate"]);
                                ApprovalList.end = Convert.ToString(dt.Rows[0]["EndDate"]);
                                ApprovalList.poms = Convert.ToString(dt.Rows[0]["Poms_Art"]);
                                ApprovalList.department = Convert.ToString(dt.Rows[0]["department"]);
                                ApprovalList.masina = Convert.ToString(dt.Rows[0]["machine"]);
                                ApprovalList.code = Convert.ToString(dt.Rows[0]["code"]);
                                ApprovalList.cantitate = Convert.ToString(dt.Rows[0]["Quantity"]);
                                ApprovalList.conditii = Convert.ToString(dt.Rows[0]["Main_Condition"]);
                                ApprovalList.others = Convert.ToString(dt.Rows[0]["Other_Condition"]);
                                ApprovalList.cerere = Convert.ToString(dt.Rows[0]["Deviation_Cond"]);
                                ApprovalList.action = Convert.ToString(dt.Rows[0]["Action_Plan"]);
                                ApprovalList.instructiuni = Convert.ToString(dt.Rows[0]["Special_Inst"]);
                                ApprovalList.status = Convert.ToString(dt.Rows[0]["Status_"]);
                                ApprovalList.approval1 = Convert.ToString(dt.Rows[0]["approval1"]);
                                ApprovalList.approval2 = Convert.ToString(dt.Rows[0]["approval2"]);
                                ApprovalList.approval3 = Convert.ToString(dt.Rows[0]["approval3"]);
                                ApprovalList.informer1 = Convert.ToString(dt.Rows[0]["informer1"]);
                                ApprovalList.informer2 = Convert.ToString(dt.Rows[0]["informer2"]);
                                ApprovalList.informer3 = Convert.ToString(dt.Rows[0]["informer3"]);
                                ApprovalList.status1 = Convert.ToString(dt.Rows[0]["status1"]);
                                ApprovalList.status2 = Convert.ToString(dt.Rows[0]["status2"]);
                                ApprovalList.status3 = Convert.ToString(dt.Rows[0]["status3"]);
                            }
                        }
                    }
                    Response.Redirect("View.aspx");
                }
            }
        }
    }
}