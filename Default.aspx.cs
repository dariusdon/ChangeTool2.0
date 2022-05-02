
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.IO;
using System.Text;

namespace ChangeTool2._0
{
   
    public partial class _Default : Page
    {
        public static string name_str;
        
        public static string name_str2;
        public string name;
        public static int count = 0;
        public string EmailAddress { get; set; }
        public static string email;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Session["username"] = "";
            
            TextBox2.Attributes["value"] = "HelloIdiot";
           //Label12.Text = count.ToString();
           // Label12.Text =email;
        }

        public void OnClick1(object sender, EventArgs e)
        {
    
                
                try
                {
                    count = 0;
                    {
                        // create LDAP connection object  
                    Session["username"] = TextBox1.Text;
                    if ((string)Session["username"] == "")
                    {
                        Response.Redirect("Default.aspx");
                    }
                    DirectoryEntry myLdapConnection = createDirectoryEntry();

                        // create search object which operates on LDAP connection object  
                        // and set search object to only find the user specified  

                        DirectorySearcher searcher = new DirectorySearcher(myLdapConnection);
                        searcher.SearchScope = SearchScope.Subtree;
                        searcher.Filter = "(sAMAccountName=" + Session["username"] + ")";

                        searcher.PropertiesToLoad.Add("mail");
                        searcher.PropertiesToLoad.Add("sAMAccountName");
                        SearchResult result = searcher.FindOne();
                        if (result.Properties.Contains("mail"))
                        {
                            HttpCookie cookie = new HttpCookie("MyCookie");

                            string resulting = result.Properties["mail"][0].ToString();

                            Session["name"] = resulting;
                        }
                        else
                        {
                            Label12.Text = "Not found";
                        }
                        if (result.Properties.Contains("sAMAcoountName"))
                    {
                        HttpCookie cookie = new HttpCookie("MyCookie");
                        string results = result.Properties["sAMAccountName"][0].ToString();
                        if (Session["username"] == result)
                        {
                            Response.Redirect("Index.aspx");
                        }
                        else
                        {
                            Response.Redirect("Default.aspx");
                        }
                    }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught:\n\n" + ex.ToString());
                }
            Response.Redirect("Index.aspx");
        }
        
       public static DirectoryEntry createDirectoryEntry()
        {
            // create and return new LDAP connection with desired settings  

            DirectoryEntry ldapConnection = new DirectoryEntry("ti2c203a.tiretech2.contiwan.com:389");
            ldapConnection.Path = "LDAP://OU=Users,OU=tma2,OU=ro,OU=lda,DC=tiretech2,DC=contiwan,DC=com";
            ldapConnection.AuthenticationType = AuthenticationTypes.Secure;

            return ldapConnection;
        }
        public void OnClick(object sender,EventArgs e)
        {
            name_str2 = TextBox1.Text;
            Response.Redirect("Index.aspx");
        }
    }
}