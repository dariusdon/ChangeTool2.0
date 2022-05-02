<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApprovalList1.aspx.cs" Inherits="ChangeTool2._0.ApprovalList1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="font-size:30px; margin-left:50px">
                 <asp:Label ID="Label31" runat="server" Text="Poms:"></asp:Label></p>
            <p style="font-size:20px; margin-left:0px; margin-bottom: 19px;">
            <asp:Label ID="Label9" runat="server" Text="Nr.doc. Poms si paragraful/ No. of PoMS document and paragraph:"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
            </p>
            <div style="border:3px">
            <p style="font-size:20px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
  
            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Label ID="Label3" runat="server" Text="Creat de/Created_By:"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            </div>
            <br />
            <p style="font-size:20px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
            <asp:Label ID="Label5" runat="server" Text="Data inceput/Start Date:"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Label ID="Label7" runat="server" Text="Data final/End Date:"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            </p>
            <br />
            <p style="font-size:20px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
            <asp:Label ID="Label11" runat="server" Text="Process/Department:"></asp:Label>
            <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label13" runat="server" Text="Masina/Machine:"></asp:Label>
            <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label15" runat="server" Text="Codul sau descrierea produsului/ Code No. or description of the product:"></asp:Label>
            <asp:Label ID="Label16" runat="server" Text=""></asp:Label>
            </p>
            <p style="font-size:20px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
            <br />
            <asp:Label ID="Label29" runat="server" Text="Cantitate/Quantity:"></asp:Label>
            <asp:Label ID="Label30" runat="server" Text=""></asp:Label>
            </p>
            <p style="font-size:20px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
            <br />
            <asp:Label ID="Label17" runat="server" Text="Conditii principale/Main Conditions:"></asp:Label>
            <br/>
            <asp:Label ID="Label18" runat="server" Text=""></asp:Label>
            </p>
            <p style="font-size:17px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
            <br />
            <asp:Label ID="Label19" runat="server" Text="Conditiile care au cauzat cererea de derogare/The Conditions that caused the Deviation to be requested:"></asp:Label>
            <br/>
            <asp:Label ID="Label20" runat="server" Text=""></asp:Label>
            </p>
            <p style="font-size:20px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
            <br />
            <asp:Label ID="Label21" runat="server" Text="Plan de actiune/Action plan:"></asp:Label>
            <br/>
            <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
            </p>
            <p style="font-size:20px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
            <br />
            <asp:Label ID="Label23" runat="server" Text="Instructiuni Speciale/Special Instructions:"></asp:Label>
            <br />
            <asp:Label ID="Label24" runat="server" Text=""></asp:Label>
            </p>
            <p style="font-size:20px; margin-left:2px; margin-top:2px; margin-bottom:2px; margin-right:2px">
            <br />
            <asp:Label ID="Label25" runat="server" Text="Aprobator(i)/Approver(s):"></asp:Label>
            <asp:Label ID="Label26" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label27" runat="server" Text="Informat(i)/Informer(s):"></asp:Label>
            <asp:Label ID="Label28" runat="server" Text=""></asp:Label>
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
        </div>
        <div style="margin-left:800px;margin-top:100px">
        <input id="print" name="btnPrint" type="button" value="Print" onclick="window.print()" class="singin" runat="server"/>
        </div>
    </form>
   
</body>
</html>
