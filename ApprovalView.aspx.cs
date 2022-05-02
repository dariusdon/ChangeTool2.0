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
using System.Net;

namespace ChangeTool2._0
{
    public partial class ApprovalView : System.Web.UI.Page
    {
        //aici e facut template-ul pentru vizualizare in caz de printare si acceptare
        //sa nu uiti de mail-urile pentru rejected
        //aici sa pui un textbox pentru a rejecta cererea
        //si sa trimiti acest textbox dupa id in baza de date

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
                "-" + (string)Session["status2A"] + "<br/>" + (string)Session["approval3A"] + "-" + (string)Session["status3A"]
                + " " + (string)Session["approval4A"] + "-" + (string)Session["status4A"] + "<br/>" + (string)Session["approval5A"] + "-" + (string)Session["status5A"]
                + " " + (string)Session["approval6A"] + "-" + (string)Session["status6A"];
            Label28.Text = " " + (string)Session["informer1A"] + " " + (string)Session["informer2A"] + " " + (string)Session["informer3A"] + " " +
                " " + (string)Session["informer4A"] + " " + (string)Session["informer5A"] + " " + (string)Session["informer6A"] + " ";
            if ((string)Session["statusA"] == "Release")
            {
                para.Visible = false;
                print.Visible = true;
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
            }
            if((string)Session["statusA"] == "Pending")
            {
                print.Visible = false;
                Button1.Visible = true;
                Button2.Visible = true;
                Label34.Visible = true;
                textarea2.Visible = true;
                Button3.Visible = true;
            }
            if ((string)Session["statusA"] == "Rejected")
            {
                print.Visible = false;
                Button1.Visible = true;
                Button2.Visible = true;
                Label34.Visible = true;
                textarea2.Visible = true;
                Button3.Visible = false;
            }
            if ((string)Session["statusA"] == "Created")
            {
                print.Visible = false;
                Button1.Visible = true;
                Button2.Visible = true;
                Label34.Visible = true;
                textarea2.Visible = true;
                Button3.Visible = true;
            }
            if((string)Session["status1A"] == "approved" && (string)Session["approval1A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = true;
            }
            if ((string)Session["status2A"] == "approved" && (string)Session["approval2A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = true;
            }
            if ((string)Session["status3A"] == "approved" && (string)Session["approval3A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = true;
            }
            if ((string)Session["status4A"] == "approved" && (string)Session["approval4A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = true;
            }
            if ((string)Session["status5A"] == "approved" && (string)Session["approval5A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = true;
            }
            if ((string)Session["status6A"] == "approved" && (string)Session["approval6A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = true;
            }

            if ((string)Session["status1A"] == "rejected" && (string)Session["approval1A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = false;
            }
            if ((string)Session["status2A"] == "rejected" && (string)Session["approval2A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
            }
            if ((string)Session["status3A"] == "rejected" && (string)Session["approval3A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = false;
            }
            if ((string)Session["status4A"] == "rejected" && (string)Session["approval4A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = false;
            }
            if ((string)Session["status5A"] == "rejected" && (string)Session["approval5A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = false;
            }
            if ((string)Session["status6A"] == "rejected" && (string)Session["approval6A"] == (string)Session["name"])
            {
                Button1.Visible = false;
                Button2.Visible = false;
                Label34.Visible = false;
                textarea2.Visible = false;
                Button3.Visible = false;
            }
        }

        protected void Download(object sender, EventArgs e)
        {
            if (File.Exists(Server.MapPath("~/File/" + Session["numberA"] + ".pdf")))
            {
                Response.ContentType = "application/pdf";

                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Session["numberA"] + ".pdf");
                Response.TransmitFile(Server.MapPath("~/File/" + Session["numberA"] + ".pdf"));
                Response.End();
            }
            if (File.Exists(Server.MapPath("~/File/" + Session["numberA"] + ".xlsx")))
            {
                Response.ContentType = "application/xlsx";

                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Session["numberA"] + ".xlsx");
                Response.TransmitFile(Server.MapPath("~/File/" + Session["numberA"] + ".xlsx"));
                Response.End();
            }

            if (File.Exists(Server.MapPath("~/File/" + Session["numberA"] + ".xls")))
            {
                Response.ContentType = "application/xlsx";

                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Session["numberA"] + ".xls");
                Response.TransmitFile(Server.MapPath("~/File/" + Session["numberA"] + ".xls"));
                Response.End();
            }

            if (File.Exists(Server.MapPath("~/File/" + Session["numberA"] + ".docx")))
            {
                Response.ContentType = "application/docx";

                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Session["numberA"] + ".docx");
                Response.TransmitFile(Server.MapPath("~/File/" + Session["numberA"] + ".docx"));
                Response.End();
            }
            if (File.Exists(Server.MapPath("~/File/" + Session["numberA"] + ".doc")))
            {
                Response.ContentType = "application/doc";

                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Session["numberA"] + ".doc");
                Response.TransmitFile(Server.MapPath("~/File/" + Session["numberA"] + ".doc"));
                Response.End();
            }

            //else if(Response.ContentType == "application/xlxs")
            //{
            //    Response.AppendHeader("Content-Disposition", "attachment; filename=" + Session["numberA"] + ".xlxs");
            //    Response.TransmitFile(Server.MapPath("~/File/" + Session["numberA"] + ".xlxs"));
            //    Response.End();
            //}
            //else if (Response.ContentType == "application/docx")
            //{
            //    Response.AppendHeader("Content-Disposition", "attachment; filename=" + Session["numberA"] + ".docx");
            //    Response.TransmitFile(Server.MapPath("~/File/" + Session["numberA"] + ".docx"));
            //    Response.End();
            //}
        }
    


        public void Send_Email(string approval)
        {

            try
            {
                //Send Email
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("TI_TI_SM_CHANGE_TI@continental.com");// Sender details here, replace with valid value



                Msg.Subject = "Cerere de derogare/Deviation Request:" + Session["numberA"]; // subject of email
                                                                                             //Msg.To.Add("natalia.nicoleta.dragoescu@conti.de"); //Add Email id, to which we will send email
                Msg.To.Add(approval);


                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Va informam ca derogarea cu numarul:" +" "+ Session["numberA"] + " " + "a fost Aprobata/Eliberata");
                sb.AppendLine(" • Sesizare facuta de: " + Session["createA"]);
                sb.AppendLine(" • Data de inceput: " + Session["startA"]);
                sb.AppendLine(" • Data de sfarsit:" + Session["endA"]);
                sb.AppendLine("Pentru mai multe detalii intrati in ChangeTool2.0 la sectiunea:" + "MyCreate");
                sb.AppendLine("https://tias068a.tiretech2.contiwan.com/");
                sb.AppendLine();
                sb.AppendLine(" • We inform you that the deviation request number:" + " " + Session["numberA"] + " " + "was Approved/Released");
                sb.AppendLine(" • Request was made by: " + Session["createA"]);
                sb.AppendLine(" • Start Date: " + Session["startA"]);
                sb.AppendLine(" • End Date:" + Session["endA"]);
                sb.AppendLine("For more informations can be accessed in ChangeTool2.0 at section:" + "MyCreate");
                sb.AppendLine("https://tias068a.tiretech2.contiwan.com/");
                //Label2.Text = sb.ToString().Replace(Environment.NewLine, "<br />");
                Msg.Body = sb.ToString().Replace(Environment.NewLine, "<br />");



                Msg.IsBodyHtml = true;
                Msg.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false; // to get rid of error "SMTP server requires a secure connection"
                smtp.Host = "smtphubeu.contiwan.com";
                smtp.Port = 2525;
                smtp.Credentials = new System.Net.NetworkCredential("", "");// replace with valid value
                smtp.EnableSsl = true;
                smtp.Timeout = 70000;
                smtp.Send(Msg);
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }

        public void Send_Reject(string approval)
        {

            try
            {
                //Send Email
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("TI_TI_SM_CHANGE_TI@continental.com");// Sender details here, replace with valid value



                Msg.Subject = "Cerere de derogare/Deviation Request:" +" "+ Session["numberA"]; // subject of email
                                                                                             //Msg.To.Add("natalia.nicoleta.dragoescu@conti.de"); //Add Email id, to which we will send email
                Msg.To.Add(approval);


                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Va informam ca derogarea cu numarul:" +" "+ Session["numberA"] + " a fost rejectata de:" + Session["name"]);
                sb.AppendLine(" • Sesizare facuta de: " + Session["createA"]);
                sb.AppendLine(" • Data de inceput: " + Session["startA"]);
                sb.AppendLine(" • Data de sfarsit:" + Session["endA"]);
                sb.AppendLine(" •A fost rejectate din urmatorul motiv:" + motiv);
                sb.AppendLine(" •Pentru mai multe detalii intrati in ChangeTool2.0 la sectiunea:" + "MyCreate");
                sb.AppendLine("https://tias068a.tiretech2.contiwan.com/");
                sb.AppendLine();
                sb.AppendLine(" • We inform you that the deviation request number:" + " " + Session["numberA"] + " " + "was Rejected by:" + Session["name"]);
                sb.AppendLine(" • Request was made by: " + Session["createA"]);
                sb.AppendLine(" • Start Date: " + Session["startA"]);
                sb.AppendLine(" • End Date:" + Session["endA"]);
                sb.AppendLine("For more informations can be accessed in ChangeTool2.0 at section:" + "MyCreate");
                sb.AppendLine("Deviation was rejected for the following reason: " + motiv);
                sb.AppendLine("https://tias068a.tiretech2.contiwan.com/");
                //Label2.Text = sb.ToString().Replace(Environment.NewLine, "<br />");
                Msg.Body = sb.ToString().Replace(Environment.NewLine, "<br />");



                Msg.IsBodyHtml = true;
                Msg.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false; // to get rid of error "SMTP server requires a secure connection"
                smtp.Host = "smtphubeu.contiwan.com";
                smtp.Port = 2525;
                smtp.Credentials = new System.Net.NetworkCredential("", "");// replace with valid value
                smtp.EnableSsl = true;
                smtp.Timeout = 70000;
                smtp.Send(Msg);
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if ((string)Session["status1A"] == "requested" && (string)Session["approval1A"] == (string)Session["name"])
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status1 = 'approved'
                        WHERE ID ='" + Session["numberA"] + "' and approval1= '" + (string)Session["approval1A"] + "' ";
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
            if ((string)Session["status2A"] == "requested" && (string)Session["approval2A"] == (string)Session["name"])
            {
                string constr1 = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr1))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status2 = 'approved'
                        WHERE ID ='" + Session["numberA"] + "' and approval2= '" + Session["name"] + "' ";
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
            if ((string)Session["status3A"] == "requested" && (string)Session["approval3A"] == (string)Session["name"])
            {
                string constr1 = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr1))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status3 = 'approved'
                        WHERE ID ='" + Session["numberA"] + "' and approval3= '" + (string)Session["approval3A"] + "' ";
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
            if ((string)Session["status4A"] == "requested" && (string)Session["approval4A"] == (string)Session["name"])
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status4 = 'approved'
                        WHERE ID ='" + Session["numberA"] + "' and approval4= '" + (string)Session["approval4A"] + "' ";
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
            if ((string)Session["status5A"] == "requested" && (string)Session["approval5A"] == (string)Session["name"])
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status5 = 'approved'
                        WHERE ID ='" + Session["numberA"] + "' and approval5= '" + (string)Session["approval5A"] + "' ";
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
            if ((string)Session["status6A"] == "requested" && (string)Session["approval6A"] == (string)Session["name"])
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status6 = 'approved'
                        WHERE ID ='" + Session["numberA"] + "' and approval6= '" + (string)Session["approval6A"] + "' ";
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
            string sqlinf = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(sqlinf))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"SELECT informer1,informer2,informer3,informer4,informer5,informer6
                    FROM [dbo].[Change2_0]
                    WHERE ID ='" + Session["numberA"] + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        Session["informer1A"] = Convert.ToString(dt.Rows[0]["informer1"]);
                        Session["informer2A"] = Convert.ToString(dt.Rows[0]["informer2"]);
                        Session["informer3A"] = Convert.ToString(dt.Rows[0]["informer3"]);
                        Session["informer4A"] = Convert.ToString(dt.Rows[0]["informer4"]);
                        Session["informer5A"] = Convert.ToString(dt.Rows[0]["informer5"]);
                        Session["informer6A"] = Convert.ToString(dt.Rows[0]["informer6"]);
                    }
                }
            }
            if((string)Session["informer1A"] != "")
            {
                Send_Email((string)Session["informer1A"]);
            }

            if ((string)Session["informer2A"] != "")
            {
                Send_Email((string)Session["informer2A"]);
            }

            if ((string)Session["informer3A"] != "")
            {
                Send_Email((string)Session["informer3A"]);
            }

            if ((string)Session["informer4A"] != "")
            {
                Send_Email((string)Session["informer4A"]);
            }

            if ((string)Session["informer5A"] != "")
            {
                Send_Email((string)Session["informer5A"]);
            }

            if ((string)Session["informer6A"] != "")
            {
                Send_Email((string)Session["informer6A"]);
            }
            
            string sqlstring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(sqlstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"SELECT status1,status2,status3,status4,status5,status6
                    FROM [dbo].[Change2_0]
                    WHERE ID ='" + Session["numberA"] + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        Session["status1A"] = Convert.ToString(dt.Rows[0]["status1"]);
                        Session["status2A"] = Convert.ToString(dt.Rows[0]["status2"]);
                        Session["status3A"] = Convert.ToString(dt.Rows[0]["status3"]);
                        Session["status4A"] = Convert.ToString(dt.Rows[0]["status4"]);
                        Session["status5A"] = Convert.ToString(dt.Rows[0]["status5"]);
                        Session["status6A"] = Convert.ToString(dt.Rows[0]["status6"]);
                    }
                }
            }
            if ((string)Session["status1A"] == "approved" && (string)Session["status2A"] == "")
            {
                Send_Email((string)Session["createA"]);
                Send_Email((string)Session["approval1A"]);
            }
            if ((string)Session["status1A"] == "approved" && (string)Session["status2A"] == "approved" && (string)Session["status3A"] == "" && (string)Session["status4A"] == "" && (string)Session["status5A"] == "" && (string)Session["status6A"] == "")
            {
                Send_Email((string)Session["createA"]);
                Send_Email((string)Session["approval1A"]);
                Send_Email((string)Session["approval2A"]);
            }
            if ((string)Session["status1A"] == "approved" && (string)Session["status2A"] == "approved" && (string)Session["status3A"] == "approved" && (string)Session["status4A"] == "" && (string)Session["status5A"] == "" && (string)Session["status6A"] == "")
            {
                Send_Email((string)Session["createA"]);
                Send_Email((string)Session["approval1A"]);
                Send_Email((string)Session["approval2A"]);
                Send_Email((string)Session["approval3A"]);
            }
            if ((string)Session["status1A"] == "approved" && (string)Session["status2A"] == "approved" && (string)Session["status3A"] == "approved" && (string)Session["status4A"] == "approved" && (string)Session["status5A"] == "" && (string)Session["status6A"] == "")
            {
                Send_Email((string)Session["createA"]);
                Send_Email((string)Session["approval1A"]);
                Send_Email((string)Session["approval2A"]);
                Send_Email((string)Session["approval3A"]);
                Send_Email((string)Session["approval4A"]);
            }
            if ((string)Session["status1A"] == "approved" && (string)Session["status2A"] == "approved" && (string)Session["status3A"] == "approved" && (string)Session["status4A"] == "approved" && (string)Session["status5A"] == "approved" && (string)Session["status6A"] == "")
            {
                Send_Email((string)Session["createA"]);
                Send_Email((string)Session["approval1A"]);
                Send_Email((string)Session["approval2A"]);
                Send_Email((string)Session["approval3A"]);
                Send_Email((string)Session["approval4A"]);
                Send_Email((string)Session["approval5A"]);
            }
            if ((string)Session["status1A"] == "approved" && (string)Session["status2A"] == "approved" && (string)Session["status3A"] == "approved" && (string)Session["status4A"] == "approved" && (string)Session["status5A"] == "approved" && (string)Session["status6A"] == "approved")
            {
                Send_Email((string)Session["createA"]);
                Send_Email((string)Session["approval1A"]);
                Send_Email((string)Session["approval2A"]);
                Send_Email((string)Session["approval3A"]);
                Send_Email((string)Session["approval4A"]);
                Send_Email((string)Session["approval5A"]);
                Send_Email((string)Session["approval6A"]);
            }
            Response.Redirect("Accepted.aspx");
        }

        public static string motiv;
        protected void Button2_Click(object sender, EventArgs e)
        {
            motiv = textarea2.InnerText;
            string constr5 = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr5))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = @"Update dbo.Change2_0
                    set motiv = '" + motiv + "' where ID =  ='" + Session["numberA"] + "'";
                    
                }
            }
                    if ((string)Session["status1A"] == "requested" && (string)Session["approval1A"] == (string)Session["name"])
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status1 = 'rejected'
                        WHERE ID ='" + Session["numberA"] + "' and approval1= '" + (string)Session["approval1A"] + "' ";
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
            if ((string)Session["status2A"] == "requested" && (string)Session["approval2A"] == (string)Session["name"])
            {
                string constr1 = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr1))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status2 = 'rejected'
                        WHERE ID ='" + Session["numberA"] + "' and approval2= '" + (string)Session["approval2A"] + "' ";
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
            if ((string)Session["status3A"] == "requested" && (string)Session["approval3A"] == (string)Session["name"])
            {
                string constr1 = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr1))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status3 = 'rejected'
                        WHERE ID ='" + Session["numberA"] + "' and approval3= '" + (string)Session["approval3A"] + "' ";
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
            if ((string)Session["status4A"] == "requested" && (string)Session["approval4A"] == (string)Session["name"])
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status4 = 'rejected'
                        WHERE ID ='" + Session["numberA"] + "' and approval4= '" + (string)Session["approval4A"] + "' ";
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
            if ((string)Session["status5A"] == "requested" && (string)Session["approval5A"] == (string)Session["name"])
            {
                string constr1 = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr1))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status5 = 'rejected'
                        WHERE ID ='" + Session["numberA"] + "' and approval5= '" + (string)Session["approval2A"] + "' ";
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
            if ((string)Session["status6A"] == "requested" && (string)Session["approval6A"] == (string)Session["name"])
            {
                string constr1 = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr1))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"Update dbo.Change2_0
                        set status6 = 'rejected'
                        WHERE ID ='" + Session["numberA"] + "' and approval6= '" + (string)Session["approval6A"] + "' ";
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
            string sqlstring = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(sqlstring))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"SELECT status1,status2,status3,status4,status5,status6
                    FROM [dbo].[Change2_0]
                    WHERE ID ='" + Session["numberA"] + "'";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        Session["status1A"] = Convert.ToString(dt.Rows[0]["status1"]);
                        Session["status2A"] = Convert.ToString(dt.Rows[0]["status2"]);
                        Session["status3A"] = Convert.ToString(dt.Rows[0]["status3"]);
                        Session["status4A"] = Convert.ToString(dt.Rows[0]["status4"]);
                        Session["status5A"] = Convert.ToString(dt.Rows[0]["status5"]);
                        Session["status6A"] = Convert.ToString(dt.Rows[0]["status6"]);
                    }
                }
                if((string)Session["status1A"] == "rejected")
                {
                    if((string)Session["status2A"] == "requested")
                    {
                        Send_Reject((string)Session["approval2A"]);
                    }
                    if((string)Session["status3A"] == "requested")
                    {
                        Send_Reject((string)Session["approval3A"]);
                    }
                    if ((string)Session["status4A"] == "requested")
                    {
                        Send_Reject((string)Session["approval4A"]);
                    }
                    if ((string)Session["status5A"] == "requested")
                    {
                        Send_Reject((string)Session["approval5A"]);
                    }
                    if((string)Session["status6A"] == "requested")
                    {
                        Send_Reject((string)Session["approval6A"]);
                    }
                    //Send_Reject((string)Session[(string)Session["createA"]]);
                }

                if ((string)Session["status2A"] == "rejected")
                {
                    if ((string)Session["status1A"] == "requested")
                    {
                        Send_Reject((string)Session["approval1A"]);
                    }
                    if ((string)Session["status3A"] == "requested")
                    {
                        Send_Reject((string)Session["approval3A"]);
                    }
                    if ((string)Session["status4A"] == "requested")
                    {
                        Send_Reject((string)Session["approval4A"]);
                    }
                    if ((string)Session["status5A"] == "requested")
                    {
                        Send_Reject((string)Session["approval5A"]);
                    }
                    if ((string)Session["status6A"] == "requested")
                    {
                        Send_Reject((string)Session["approval6A"]);
                    }
                    //Send_Reject((string)Session["createA"]);
                }
                if ((string)Session["status3A"] == "rejected")
                {
                    if ((string)Session["status1A"] == "requested")
                    {
                        Send_Reject((string)Session["approval1A"]);
                    }
                    if ((string)Session["status2A"] == "requested")
                    {
                        Send_Reject((string)Session["approval2A"]);
                    }
                    if ((string)Session["status4A"] == "requested")
                    {
                        Send_Reject((string)Session["approval4A"]);
                    }
                    if ((string)Session["status5A"] == "requested")
                    {
                        Send_Reject((string)Session["approval5A"]);
                    }
                    if ((string)Session["status6A"] == "requested")
                    {
                        Send_Reject((string)Session["approval6A"]);
                    }
                   // Send_Reject((string)Session["createA"]);
                }

                if ((string)Session["status4A"] == "rejected")
                {
                    if ((string)Session["status1A"] == "requested")
                    {
                        Send_Reject((string)Session["approval1A"]);
                    }
                    if ((string)Session["status2A"] == "requested")
                    {
                        Send_Reject((string)Session["approval2A"]);
                    }
                    if ((string)Session["status3A"] == "requested")
                    {
                        Send_Reject((string)Session["approval3A"]);
                    }
                    if ((string)Session["status5A"] == "requested")
                    {
                        Send_Reject((string)Session["approval5A"]);
                    }
                    if ((string)Session["status6A"] == "requested")
                    {
                        Send_Reject((string)Session["approval6A"]);
                    }
                    //Send_Reject((string)Session["createA"]);
                }

                if ((string)Session["status5A"] == "rejected")
                {
                    if ((string)Session["status1A"] == "requested")
                    {
                        Send_Reject((string)Session["approval1A"]);
                    }
                    if ((string)Session["status2A"] == "requested")
                    {
                        Send_Reject((string)Session["approval2A"]);
                    }
                    if ((string)Session["status3A"] == "requested")
                    {
                        Send_Reject((string)Session["approval3A"]);
                    }
                    if ((string)Session["status4A"] == "requested")
                    {
                        Send_Reject((string)Session["approval4A"]);
                    }
                    if ((string)Session["status6A"] == "requested")
                    {
                        Send_Reject((string)Session["approval6A"]);
                    }
                   // Send_Reject((string)Session["createA"]);
                }
                if ((string)Session["status6A"] == "rejected")
                {
                    if ((string)Session["status1A"] == "requested")
                    {
                        Send_Reject((string)Session["approval1A"]);
                    }
                    if ((string)Session["status2A"] == "requested")
                    {
                        Send_Reject((string)Session["approval2A"]);
                    }
                    if ((string)Session["status3A"] == "requested")
                    {
                        Send_Reject((string)Session["approval3A"]);
                    }
                    if ((string)Session["status5A"] == "requested")
                    {
                        Send_Reject((string)Session["approval5A"]);
                    }
                    if ((string)Session["status4A"] == "requested")
                    {
                        Send_Reject((string)Session["approval4A"]);
                    }
                   // Send_Reject((string)Session["createA"]);
                }
             


                string sqlinf = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con1 = new SqlConnection(sqlinf))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        string sql = @"SELECT informer1,informer2,informer3,informer4,informer5,informer6
                    FROM [dbo].[Change2_0]
                    WHERE ID ='" + Session["numberA"] + "'";
                        cmd.CommandText = sql;
                        cmd.Connection = con1;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            Session["informer1A"] = Convert.ToString(dt.Rows[0]["informer1"]);
                            Session["informer2A"] = Convert.ToString(dt.Rows[0]["informer2"]);
                            Session["informer3A"] = Convert.ToString(dt.Rows[0]["informer3"]);
                            Session["informer4A"] = Convert.ToString(dt.Rows[0]["informer4"]);
                            Session["informer5A"] = Convert.ToString(dt.Rows[0]["informer5"]);
                            Session["informer6A"] = Convert.ToString(dt.Rows[0]["informer6"]);
                        }
                    }
                }
                if ((string)Session["informer1A"] != "")
                {
                    Send_Reject((string)Session["informer1A"]);
                }

                if ((string)Session["informer2A"] != "")
                {
                    Send_Reject((string)Session["informer2A"]);
                }

                if ((string)Session["informer3A"] != "")
                {
                    Send_Reject((string)Session["informer3A"]);
                }

                if ((string)Session["informer4A"] != "")
                {
                    Send_Reject((string)Session["informer4A"]);
                }

                if ((string)Session["informer5A"] != "")
                {
                    Send_Reject((string)Session["informer5A"]);
                }

                if ((string)Session["informer6A"] != "")
                {
                    Send_Reject((string)Session["informer6A"]);
                }
                Send_Reject((string)Session["createA"]);
                Response.Redirect("Deny.aspx");
            }
        }
    }
    
}