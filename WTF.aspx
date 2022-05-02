<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WTF.aspx.cs" Inherits="ChangeTool2._0.Test" %>
<link rel="stylesheet" href="CSS/CreateCSS.css">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label3" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label4" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label5" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label6" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label7" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label8" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label9" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label10" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label11" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label12" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label13" runat="server" Text="Label" Font-Size="22px"></asp:Label><br/>
            <asp:Label ID="Label15" runat="server" Text="" Font-Size="22px"></asp:Label><br/>
            <br />
            <asp:Label ID="Label14" runat="server" Text="" Font-Size="22px"></asp:Label><br/>
            <br/>
        </div>
        <style type="text/css">
    #btnPrint
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
</style>
<input id="btnPrint" name="btnPrint" type="button" value="Print" onclick="window.print()"/>
    </form>
</body>
</html>
