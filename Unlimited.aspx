<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Unlimited.aspx.cs" Inherits="ChangeTool2._0.Unlimited" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unlimited/Nelimitate</title>
</head>
<body style="padding-left: 100px;
    align-items: start;
    border-spacing: 10px;
    color: #000000;
    font-size: 16px;
    height: 95%;
    background-repeat:no-repeat;
    
     position: fixed;
    background-size:cover;">
    
    <form id="form1" runat="server">
        <div>
            <p style="font-size:30px; margin-left: 650px; color: #ffa500"><u>
            <asp:Label ID="Label1" runat="server" Text="Nelimitate/Unlimited"></asp:Label>
            </u></p>
        </div>
        <br />
        
        <div style="width:250px;height:125px; border-radius:10px;margin-left: 150px;">
        <asp:Panel ID="Panel1" runat="server" BorderColor="blue" style="border-radius:10px;width:250px;height:125px; border-radius:10px;" BorderStyle ="Dashed" BorderWidth="3px" CssClass="panel">
             <p style="font-size:24px; margin-left:25px; color: blue">
            <asp:Label ID="Label2" runat="server" Text="Create/Created:"></asp:Label> <asp:Label ID="Label3" runat="server" Text="11"></asp:Label>
            </p>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:ImageButton ID="ImageButton7" ImageUrl = "https://previews.123rf.com/images/rastudio/rastudio1708/rastudio170808982/84745534-cr%C3%A9er-une-ic%C3%B4ne-de-ligne-de-vecteur-post-isol%C3%A9-sur-fond-blanc-cr%C3%A9er-une-ic%C3%B4ne-de-ligne-de-publicatio.jpg" Width ="35px" AlternateText ="Create" runat="server"/>
         </asp:Panel>
        </div>
        <div style="width:300px;height:125px; border-radius:10px;margin-left: 450px; margin-top:-127px">
        <asp:Panel ID="Panel2" runat="server" BorderColor="#ffe135" style="border-radius:10px;width:300px;height:125px; border-radius:10px;" BorderStyle ="Dashed" BorderWidth="3px" CssClass="panel" Height="123px">
             <p style="font-size:24px; margin-left:25px; color: #ffe135">
            <asp:Label ID="Label4" runat="server" Text="In Asteptare/Pending:"></asp:Label> <asp:Label ID="Label5" runat="server" Text="11"></asp:Label>
            </p>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:ImageButton ID="ImageButton1" ImageUrl = "https://icon-library.com/images/fd556bda9e.svg.svg" Width ="35px" AlternateText ="Create" runat="server"/>
        </asp:Panel>
        </div>
        <div style="width:250px;height:100px; border-radius:10px;margin-left: 800px; margin-top:-125px">
        <asp:Panel ID="Panel3" runat="server" BorderColor="red" style="border-radius:10px;width:250px;height:125px; border-radius:10px;" BorderStyle ="Dashed" BorderWidth="3px" CssClass="panel">
             <p style="font-size:24px; margin-left:25px; color: red">
            <asp:Label ID="Label6" runat="server" Text="Respins/Rejected:"></asp:Label> <asp:Label ID="Label7" runat="server" Text="11"></asp:Label>
            </p>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:ImageButton ID="ImageButton2" ImageUrl = "https://aux4.iconspalace.com/uploads/94037107506498791.png" Width ="35px" AlternateText ="Create" runat="server"/>
        </asp:Panel>
        </div>
        <div style="width:250px;height:100px; border-radius:10px;margin-left: 1100px; margin-top:-100px">
        <asp:Panel ID="Panel4" runat="server" BorderColor="green" style="border-radius:10px;width:250px;height:125px; border-radius:10px;" BorderStyle ="Dashed" BorderWidth="3px" CssClass="panel">
             <p style="font-size:24px; margin-left:25px; color: green">
            <asp:Label ID="Label8" runat="server" Text="Lansare/Release:"></asp:Label> <asp:Label ID="Label9" runat="server" Text="11"></asp:Label>
            </p>
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:ImageButton ID="ImageButton3" ImageUrl = "https://www.pngitem.com/pimgs/m/288-2886114_space-icon-png-color-logo-transparent-transparent-flying.png" Width ="35px" AlternateText ="Create" runat="server"/>
        </asp:Panel>
          
        </div>
        <br />
            <br />
        <div style="margin-left:150px;font-size:26px">
            <p style="color: #ffa500">
            <asp:Label runat="server" Text="Cauta Dupa/Search By:"></asp:Label>
                <asp:TextBox ID="TextBox1" style="width:150px;height: 30px;font-size:18px" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" style="width:150px;height: 35px;font-size:20px" runat="server" Text="Filtreaza" OnClick="search" />
                <asp:Button ID="Button4" style="width:150px;height: 35px;font-size:20px" runat="server" Text="Sterge Filtru" OnClick="refresh"/>
                </div>
        <div style="margin-top:0px; margin-left:100px">
            <asp:GridView ID="GridView1" OnSelectedIndexChanged="OnSelectedIndexChanged" DataKeyNames="ID,Created_by,StartDate,Status_" Width="1300px" OnRowDeleting="RowDeleting" AllowPaging="true" Font-size="22px"  runat="server" HeaderStyle-BackColor="#ffa500" HeaderStyle-ForeColor="Black" PageSize="12"  onpageindexchanging="GrdEmp_PageIndexChanging" AllowSorting="true" OnSorting="Details_sort">
         
         <PagerSettings mode="Numeric"
          position="Bottom"           
          pagebuttoncount="10" />
         <PagerStyle backcolor="#ffa500"
          height="30px"
          verticalalign="Bottom"
          horizontalalign="Right"/>
                  <Columns>
                      <asp:CommandField ButtonType="Image" SelectImageUrl ="https://th.bing.com/th/id/OIP.aDsjTGbLbGibIEp85bgjlwHaHa?pid=ImgDet&w=512&h=512&rs=1" ControlStyle-Width="25" ShowSelectButton="true" HeaderText ="View" CancelText="true"/>
                 
                      <asp:CommandField ButtonType="Image" DeleteImageUrl= "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThjl7mlwlpu7GjhxWZhtQIHCVajZN9Hh1FMGXeBRu5_OQBsnTgmE5t74V03FPuN5SQQ7E&usqp=CAU" ControlStyle-Width="30" ShowDeleteButton="true" HeaderText ="Delete"/>
                  </Columns>
     </asp:GridView>
        </div>
        <div style="margin-left: 550px;margin-top: 30px; width: 90%; height:125px;background-image: url(https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvui-KTGNqCJAMjNpGsdev9taMQu9MD98IwQ&usqp=CAU);background-repeat:no-repeat;">

        </div>
    </form>
</body>
</html>