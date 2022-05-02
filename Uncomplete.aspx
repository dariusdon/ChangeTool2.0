<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uncomplete.aspx.cs" Inherits="ChangeTool2._0.Uncomplete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top:250px; margin-left:550px;width: 500px; height: 200px; border-color: #ffa500; border-style:dashed; border:3px">
            <p style="font:22px; margin-left:25px; color:#ffa500;">
            <asp:Label ID="Label1" runat="server" Font-Size="26px" Text="Va rugam sa completati toate campurile:"></asp:Label>
            </p >
            <p style="font:22px;margin-left:100px; color:#ffa500;">
            <asp:Label ID="Label3" runat="server" Font-Size="26px" Text="Please, complete all fields:"></asp:Label>
            </p>
            <div style="margin-left:150px">
            <asp:Button ID="Button1" runat="server" Text="Ok" Width="150px" Height="50px" OnClick="OnClick"/>
            </div>
        </div> 
        <style type="text/css">
           
            
    #Button1
    {
    background-color: #000000;
    color: #ffa500;
    width: 10%;
    padding: 10px 20px;
    display: block;
    height: 39px;
    border-radius: 20px;
    margin-top: 30px;
    transition: all 0.5s ease-in-out;
    border: none;
    text-transform: uppercase;
    }
    #Button1:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #Button1:focus {
        outline: none;
        color: #ffa500;
    }
     </style>
   </form>
</body>
</html>
