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
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Windows.Forms;

namespace ChangeTool2._0
{
    
    public partial class Create : System.Web.UI.Page
    {
        public string create;
        public string start;
        public string end;
        public string poms;
        public string department;
        public string machine;
        public string code;
        public string quantity;
        public string conditii;
        public string others;
        public string derogare;
        public string action;
        public string special;
        public string email;

        public string approval1;
        public string approval2;
        public string approval3;
        public string approval4;
        public string approval5;
        public string approval6;
        public string status1;
        public string status2;
        public string status3;
        public string status4;
        public string status5;
        public string status6;

        public string informer1;
        public string informer2;
        public string informer3;
        public string informer4;
        public string informer5;
        public string informer6;

        public  List<string> approvals;
        public  List<string> informers;
        public int n = 0;

        public bool Sorted { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Visible = true;
            //if(IsPostBack == true)
            //{
            //    Response.Redirect("Create.aspx");
            //}
            
            TextBox1.Text = (string)Session["name"];
            TextBox1.ReadOnly = true;
            //Button2.Visible = false;
            //Button3.Visible = false;
            index();
        }
     

        public static int index1;
        public static int index2;
        public void index()
        {
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"  Select top 1 ID from dbo.Change2_0 order by ID desc";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        index1 = Convert.ToInt32(dt.Rows[0]["ID"]);
                        Session["index2"] = Convert.ToInt32(dt.Rows[0]["ID"]) + 1;
                        Label15.Text = Session["index2"].ToString();
                    }
                }
            }
        }
        //protected void add_approver(object sender, EventArgs e)
        //{
        //    string[] items = ListBox2.Items
        //    .OfType<object>()
        //    .Select(item => item.ToString())
        //    .ToArray();
        //    string result = string.Join(";", items);
        //    //Response.Write(result);
        //    approvals = result.Split(';').ToList();
        //    Response.Write(approvals[0].ToString());
        //    //Response.Write(approvals[1].ToString());
        //    //Response.Write(approvals[2].ToString());
        //    //Response.Write(approvals.Count);
        //    //Response.Write(approvals.Capacity);
        //}
        //protected void add_informer(object sender, EventArgs e)
        //{
        //    //email = TextBox8.Text;
        //    //TextBox8.Text = email + ";";
        //    //informers = TextBox8.Text.Split(';').ToList();

        //}
        public void Send_Email(string approval)
        {

            try
            {
                //Send Email
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("TI_TI_SM_CHANGE_TI@continental.com");// Sender details here, replace with valid value



                Msg.Subject = "Cerere de derogare/Deviation Request:" + Session["index2"]; // subject of email
                                                                        //Msg.To.Add("natalia.nicoleta.dragoescu@conti.de"); //Add Email id, to which we will send email
                Msg.To.Add(approval);
        
      
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Va informam ca a fost creata derogarea cu numarul:" + Session["index2"]);
                sb.AppendLine("Va rugam sa acceptati sau sa refuzati aceasta cerere de derogare!");
                sb.AppendLine(" • Sesizare facuta de: " + create);
                sb.AppendLine(" • Data de inceput: " + start);
                sb.AppendLine(" • Data de sfarsit:" + end);
                sb.AppendLine(" • Pentru mai multe detalii intrati in ChangeTool2.0 la sectiunea:ApprovalList");
                sb.AppendLine("https://tias068a.tiretech2.contiwan.com/");
                sb.AppendLine();
                sb.AppendLine(" • We inform you that the deviation request number:" + " " + Session["index2"] + " " + "was Created");
                sb.AppendLine(" • Request was made by: " + create);
                sb.AppendLine(" • Start Date: " + start);
                sb.AppendLine(" • End Date:" + end);
                sb.AppendLine(" • For more informations can be accessed in ChangeTool2.0 at section:" + "ApprovalList");
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

        public void Send_Email_toinformer(string approval)
        {

            try
            {
                //Send Email
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress("TI_TI_SM_CHANGE_TI@continental.com");// Sender details here, replace with valid value



                Msg.Subject = "Cerere de derogare/Deviation Request:" + Session["index2"]; // subject of email
                                                                               //Msg.To.Add("natalia.nicoleta.dragoescu@conti.de"); //Add Email id, to which we will send email
                Msg.To.Add(approval);


                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Va informam ca a fost creata derogarea cu numarul:" + Session["index2"]);
                sb.AppendLine(" • Sesizare facuta de: " + create);
                sb.AppendLine(" • Data de inceput: " + start);
                sb.AppendLine(" • Data de sfarsit:" + end);
                sb.AppendLine("Pentru mai multe detalii intrati in ChangeTool2.0 la sectiunea:" + "Limitate/Limited");
                sb.AppendLine("https://tias068a.tiretech2.contiwan.com/");
                sb.AppendLine();
                sb.AppendLine(" • We inform you that the deviation request number:" + " " + Session["index2"] + " " + "was Created");
                sb.AppendLine(" • Request was made by: " + create);
                sb.AppendLine(" • Start Date: " + start);
                sb.AppendLine(" • End Date:" + end);
                sb.AppendLine(" • For more informations can be accessed in ChangeTool2.0 at section:" + "Limited");
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


        protected void on_click(object sender, EventArgs e)
        {
            Button1.Visible = false;
            string folderpath = Server.MapPath("~/File/");
            FileUpload1.SaveAs(folderpath + Session["index2"] + Path.GetExtension(FileUpload1.FileName));
            create = TextBox1.Text;
            start = TextBox17.Text;
            end = TextBox16.Text;
            poms = TextBox9.Text;
            department = TextBox2.Text;
            machine = TextBox3.Text;
            code = TextBox6.Text;
            quantity = TextBox10.Text;
            conditii = DropDownList2.Text;
            //others = TextBox11.Text;
            derogare = textarea1.InnerText;
            action = textarea2.InnerText;
            special = textarea3.InnerText;
            if (create == "" || start == "" || end == "" || poms == "" || department == "" || machine == "" || code == "" || quantity == "" || conditii == "Alege conditia /Select Condition" || derogare == "" || action == "" || special == "")
            {
                Response.Redirect("Uncomplete.aspx");
            }
            string[] items = ListBox2.Items
            .OfType<object>()
            .Select(item => item.ToString())
            .ToArray();
            string result = string.Join(";", items);
            //Response.Write(result);
            approvals = result.Split(';').ToList();
            //loadingImage.Visible = true;
            //aici trebe facuta lista cu aprobatori

            string[] items1 = ListBox4.Items
            .OfType<object>()
            .Select(item => item.ToString())
            .ToArray();
            string result1 = string.Join(";", items1);
            //Response.Write(result);
            informers = result1.Split(';').ToList();

            foreach (string a in approvals) {
                if (approvals.Count == 1)
                {
                    approval1 = approvals[0].ToString();
                    status1 = "requested";
                    
                }
                if (approvals.Count == 2)
                {
                    approval1 = approvals[0].ToString();
                    approval2 = approvals[1].ToString();
                    status1 = "requested";
                    status2 = "requested";
                   
                }
                if (approvals.Count == 3) {
                    approval1 = approvals[0].ToString();
                    approval2 = approvals[1].ToString();
                    approval3 = approvals[2].ToString();
                    status1 = "requested";
                    status2 = "requested";
                    status3 = "requested";
                }
                if (approvals.Count == 4)
                {
                    approval1 = approvals[0].ToString();
                    approval2 = approvals[1].ToString();
                    approval3 = approvals[2].ToString();
                    approval4 = approvals[3].ToString();
                    status1 = "requested";
                    status2 = "requested";
                    status3 = "requested";
                    status4 = "requested";
                }
                if (approvals.Count == 5)
                {
                    approval1 = approvals[0].ToString();
                    approval2 = approvals[1].ToString();
                    approval3 = approvals[2].ToString();
                    approval4 = approvals[3].ToString();
                    approval5 = approvals[4].ToString();
                    status1 = "requested";
                    status2 = "requested";
                    status3 = "requested";
                    status4 = "requested";
                    status5 = "requested";
                }
                if (approvals.Count == 6)
                {
                    approval1 = approvals[0].ToString();
                    approval2 = approvals[1].ToString();
                    approval3 = approvals[2].ToString();
                    approval4 = approvals[3].ToString();
                    approval5 = approvals[4].ToString();
                    approval6 = approvals[5].ToString();
                    status1 = "requested";
                    status2 = "requested";
                    status3 = "requested";
                    status4 = "requested";
                    status5 = "requested";
                    status6 = "requested";
                }
            }

          //aici trebe facuta lista cu informatori
            foreach (string s in informers)
            {
                if (informers.Count == 1)
                {
                    informer1 = informers[0].ToString();
                }
                if (informers.Count == 2)
                {
                    informer1 = informers[0].ToString();
                    informer2 = informers[1].ToString();

                }
                if (informers.Count == 3)
                {
                    informer1 = informers[0].ToString();
                    informer2 = informers[1].ToString();
                    informer3 = informers[2].ToString();
                }
                if(informers.Count == 4)
                {
                    informer1 = informers[0].ToString();
                    informer2 = informers[1].ToString();
                    informer3 = informers[2].ToString();
                    informer4 = informers[3].ToString();
                }
                if (informers.Count == 5)
                {
                    informer1 = informers[0].ToString();
                    informer2 = informers[1].ToString();
                    informer3 = informers[2].ToString();
                    informer4 = informers[3].ToString();
                    informer5 = informers[4].ToString();
                }
                if(informers.Count == 6)
                {
                    informer1 = informers[0].ToString();
                    informer2 = informers[1].ToString();
                    informer3 = informers[2].ToString();
                    informer4 = informers[3].ToString();
                    informer5 = informers[4].ToString();
                    informer6 = informers[5].ToString();
                }
            }
           
          

            string complete = "Created";
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    string sql = @"  INSERT INTO[dbo].[Change2_0]
                        ([Created_By]
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
                        ,[informer6])
                        VALUES
                         ('" + create + @"'
                        , '" + start + @"'
                        ,'" + end+ @"'
                        ,'" + poms + @"'
                        ,'" + quantity + @"'
                        ,'" + conditii + @"'
                        ,'" + others + @"'
                        ,'" + derogare + @"'
                        ,'" + action + @"'
                        ,'" + special + @"'
                        ,'" + complete + @"'
                        ,'" + department + @"'
                        ,'" + machine + @"'
                        ,'" + code + @"'
                        ,'" + approval1 + @"'
                        ,'" + status1 + @"'
                        ,'" + approval2 + @"'
                        ,'" + status2 + @"'
                        ,'" + approval3 + @"'
                        ,'" + status3 + @"'
                        ,'" + approval4 + @"'
                        ,'" + status4 + @"'
                        ,'" + approval5 + @"'
                        ,'" + status5 + @"'
                        ,'" + approval6 + @"'
                        ,'" + status6 + @"'
                        ,'" + informer1 + @"'
                        ,'" + informer2 + @"'
                        ,'" + informer3 + @"'
                        ,'" + informer4 + @"'
                        ,'" + informer5 + @"'
                        ,'" + informer6 + @"'
                        );";
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                    }
                }
            }
            //aici trebuiesc trimise mail-urile pentru aprobatori in functie de cantitate
            if (approvals.Count == 1)
            {
                Send_Email(approval1);
            }
            if (approvals.Count == 2)
            {
                Send_Email(approval1);
                Send_Email(approval2);
            }
            if (approvals.Count == 3)
            {
                Send_Email(approval1);
                Send_Email(approval2);
                Send_Email(approval3);
            }
            if(approvals.Count == 4)
            {
                Send_Email(approval1);
                Send_Email(approval2);
                Send_Email(approval3);
                Send_Email(approval4);
            }
            if(approvals.Count == 5)
            {
                Send_Email(approval1);
                Send_Email(approval2);
                Send_Email(approval3);
                Send_Email(approval4);
                Send_Email(approval5);
            }
            if(approvals.Count == 6)
            {
                Send_Email(approval1);
                Send_Email(approval2);
                Send_Email(approval3);
                Send_Email(approval4);
                Send_Email(approval5);
                Send_Email(approval6);
            }

            if (informers.Count == 1)
            {
               
                Send_Email_toinformer(informer1);
            }
            if (informers.Count == 2)
            {
                Send_Email_toinformer(informer1);
                Send_Email_toinformer(informer2);

            }
            if (informers.Count == 3)
            {
                Send_Email_toinformer(informer1);
                Send_Email_toinformer(informer2);
                Send_Email_toinformer(informer3);
            }
            if (informers.Count == 4)
            {
                Send_Email_toinformer(informer1);
                Send_Email_toinformer(informer2);
                Send_Email_toinformer(informer3);
                Send_Email_toinformer(informer4);
            }
            if (informers.Count == 5)
            {
                Send_Email_toinformer(informer1);
                Send_Email_toinformer(informer2);
                Send_Email_toinformer(informer3);
                Send_Email_toinformer(informer4);
                Send_Email_toinformer(informer5);
            }
            if (informers.Count == 6)
            {
                Send_Email_toinformer(informer1);
                Send_Email_toinformer(informer2);
                Send_Email_toinformer(informer3);
                Send_Email_toinformer(informer4);
                Send_Email_toinformer(informer5);
                Send_Email_toinformer(informer6);
            }
            //aici or sa urmeze mailurile pentru informatori
            //sa nu uiti sa incerci sa ii scoti din baza de date
            //si dupa ce ai creat mail-urile
            //sa te apuci de facut raportul pentru vizualizare
            //Button1.Attributes.Add("onClick", "javascript:alert('Cererea de derogare: '" + index2 + "' a fost creata/Deviation Request: '" + index2 + "' Was Created');");
            //\\tias068a\c$\inetpub\wwwroot\Change2\Fisiere
           
            approvals.Clear();
            informers.Clear();
            Response.Redirect("CreatePopUp.aspx");
        }

        protected void _Click1(object sender, EventArgs e)
        {
            ListBox2.Items.Add(ListBox1.SelectedItem);
            ListBox1.Items.Remove(ListBox1.SelectedItem);
        }
        protected void _Click2(object sender, EventArgs e)
        {
            ListBox1.Items.Add(ListBox2.SelectedItem);
            ListBox2.Items.Remove(ListBox2.SelectedItem);
           
        }
        protected void _Click3(object sender, EventArgs e)
        {

            ListBox4.Items.Add(ListBox3.SelectedItem);
            ListBox3.Items.Remove(ListBox3.SelectedItem);
        }
        protected void _Click4(object sender, EventArgs e)
        {
            ListBox3.Items.Add(ListBox4.SelectedItem);
            ListBox4.Items.Remove(ListBox4.SelectedItem);
            
        }
    }
}