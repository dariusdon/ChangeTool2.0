<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="ChangeTool2._0.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="font-size:30px; margin-left:700px">
                <asp:Label ID="Label33" runat="server" Text="ID:"></asp:Label>
            </p>
            <p style="font-size:20px">
            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Creat de/Created_By:"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Data inceput/Start Date:"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text=":"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Data final/End Date:"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Poms:"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Departament:"></asp:Label>
            <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label13" runat="server" Text="Masina:"></asp:Label>
            <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label15" runat="server" Text="Code:"></asp:Label>
            <asp:Label ID="Label16" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label29" runat="server" Text="Quantity:"></asp:Label>
            <asp:Label ID="Label30" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label17" runat="server" Text="Conditii Derogare:"></asp:Label>
            <asp:Label ID="Label18" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label31" runat="server" Text="Alte Conditii Derogare:"></asp:Label>
            <asp:Label ID="Label32" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label19" runat="server" Text="Conditii Cerere Derogare:"></asp:Label>
            <asp:Label ID="Label20" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label21" runat="server" Text="Action Plan:"></asp:Label>
            <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label23" runat="server" Text="Instructions:"></asp:Label><br/>
            <asp:Label ID="Label24" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label25" runat="server" Text="Aprobatori:"></asp:Label><br/>
            <asp:Label ID="Label26" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label27" runat="server" Text="Informati:"></asp:Label>
            <asp:Label ID="Label28" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label34" runat="server" Text="Motiv Rejectie:"></asp:Label>
            <asp:Label ID="Label35" runat="server" Text=""></asp:Label>
            </p>
            
            <style type="text/css">
            
    #print
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
    #print:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #print:focus {
        outline: none;
        color: #ffa500;
    }
</style>
        <input id="print" name="btnPrint" type="button" value="Print" onclick="window.print()" class="singin" runat="server"/>
        </div>
    </form>
</body>
</html>
