<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"  CodeBehind="Default.aspx.cs" Inherits="ChangeTool2._0._Default" %>

<!DOCTYPE html>
<link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="CSS/LoginCSS.css">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <title>Login</title>
</head>
    <body>
        <form id="form" runat="server">
            <div>
            <p style="margin-left:825px;margin-top:-150px; color: #ffa500">
            <asp:Label ID="Label3" runat="server" Text="Change Tool 2.0" Font-Bold="true" Font-Size="30px"></asp:Label>
            </p>
            </div>
            
            <div class="login" style="margin-top:25px">
            
        <br>
        <h2 class="active"> Login Page </h2>
               
        <br/>
         <br/>
        <asp:Label ID="label1" runat="server" Text="Username" CssClass ="label" Font-Bold="true" Font-size="20px"></asp:Label>
        <br>
        <asp:TextBox ID="TextBox1" CssClass="text" runat="server" ></asp:TextBox>
        <br/>
        <asp:Label ID="label2" runat="server" Text="Password" CssClass ="label" Font-Bold="true" Font-size="20px"></asp:Label>
        <br/>
        <asp:TextBox ID="TextBox2"  TextMode="Password"  CssClass="text" runat="server" value="" ReadOnly="true"></asp:TextBox>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="OnClick1" CssClass="signin"/>
            
        <hr>
        <a href="https://connext.conti.de/communities/service/html/communitystart?communityUuid=7b1d1eaa-f1e5-41f1-a3c7-b6fcde9dcbfa">Designed By IT department 2022. Click here for more!</a>
                <br/> 
               
         </div>
               
                <br/>
             <asp:Label ID ="Label12" runat="server"></asp:Label>
        </form>
        </body>
    </html>

