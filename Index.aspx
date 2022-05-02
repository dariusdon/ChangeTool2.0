

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ChangeTool2._0.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Index</title>
    <style type="text/css">
        #form2 {
            width: 35px;
        }
    </style>
</head>

 
<body>
       <div id = "div1"  style="float:right;margin-top:6px;margin-right:12px; width: 87%; height:900px; display:block" >
        <iframe id = "framestyle" src="User.aspx" style="float:right; width: 99%; height:98% ;border-style:dashed; border-color: #ffa500; border-width:4px;" runat="server"></iframe>
        </div>
        <div id = "div2"  style="float:right;margin-top:6px;margin-right:12px; width: 87%; height:900px; display:none" >
        <iframe id = "Iframe1" src="Create.aspx" style="float:right; width: 99%; height:98% ;border-style:dashed; border-color: #ffa500; border-width:4px;" runat="server"></iframe>
        </div>
        <div id = "div3"  style="float:right;margin-top:6px;margin-right:12px; width: 87%; height:900px; display:none" >
        <iframe id = "Iframe2" src="View.aspx" style="float:right; width: 99%; height:98% ;border-style:dashed; border-color: #ffa500; border-width:4px;" runat="server"></iframe>
        </div>
        <div id = "div4"  style="float:right;margin-top:6px;margin-right:12px; width: 87%; height:900px; display:none" >
        <iframe id = "Iframe3" src="ApprovalList.aspx" style="float:right; width: 99%; height:98% ;border-style:dashed; border-color: #ffa500; border-width:4px;" runat="server"></iframe>
        </div>
     

<script type = "text/javascript">
    function replace() {
        document.getElementById("framestyle").src = "Limited.aspx";
        document.getElementById("div1").style.display = "block";
        
    }

    function replace1() {
        document.getElementById("framestyle").src = "Create.aspx";
        document.getElementById("div1").style.display = "block";
    }

</script>
    
<script type = "text/javascript">
    function replace2() {
        document.getElementById("framestyle").src = "MyCreate.aspx";
        document.getElementById("div1").style.display = "block";
    }

    function replace3() {
        document.getElementById("framestyle").src = "ApprovalList.aspx";
        document.getElementById("div1").style.display = "block";
    }

</script>
        
            <div style="border: 4px none #ffa500; width: 221px; margin-top:6px; height: 98%;" float="left">
            <div style=" padding-top:-500px">
                <p style="font-size:30px; color: #ffa500; width: 203px;"><u style="color: black;">
                <asp:Label ID="Label2" runat="server" Text="Change Tool 2.0"></asp:Label>
                </u><p/>
            </div>
            <div style="margin-top:0px; margin-left: 10px; width: 212px;">
            <img src = "https://freight.cargo.site/t/original/i/458d61393b060ea150cd87e4ae1b41839ade911c72f80086aab48d65fbb27d37/sEKMQ-10.png" style="width:200px; height:200px" />
            </div>
             
            </div>
            
            <form id="form2" style="float: left;margin-top:4px; padding-top:-30px" runat="server">
            <div style ="margin-top:20px; width: 31px; font-size:30px; color:#ffa500; text-underline-offset:auto; height: 38px;">
            <asp:ImageButton ID="ImageButton7" ImageUrl = "https://cdn-icons-png.flaticon.com/512/25/25694.png" Width ="30px" runat="server" OnClick="ImageButton7_Click"/> <br />
            <br />
   
            </div>
            <div style=" margin-top:20px; width: 33px;" >
            <asp:ImageButton ID="ImageButton2" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR-qYm20sopPihL4MqoxGAn8hDBr4xGDfcyXMb7IO_Cx25ILet2GTnKj6WVrwhWTuuEZs8&usqp=CAU" Width="30px" runat="server" OnClick="ImageButton2_Click"/> <br />
           
            </div>
            <div style=" margin-top:20px; width: 36px;" >
            <asp:ImageButton ID="ImageButton3" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSdjqZM0J7MlE_3P1YxFZ5LQEpSZmYM1DeOtg&usqp=CAU" Width="30px" runat="server" OnClick="ImageButton3_Click" />  <br />
            </div>
            
                <div style=" margin-top:20px; width: 34px;" >
            <asp:ImageButton ID="ImageButton1" ImageUrl="https://cdn-icons-png.flaticon.com/512/2881/2881263.png" Width="30px" runat="server"/><br />
            </div>
            
                    <div style=" margin-top:20px; width: 33px;" runat="server">
            <asp:ImageButton ID="ImageButton5" ImageUrl="https://library.kissclipart.com/20180927/fae/kissclipart-person-writing-icon-clipart-computer-icons-writing-6bcc79d34d54764a.png" Width="30px" runat="server" OnClick="ImageButton5_Click"/> <br />
                    </div>
            <br/>
            <br />
            <br />
            <br />
                        <div style=" margin-top:20px; width: 32px;" runat="server">
           <asp:ImageButton ID="ImageButton4" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWxZnizfNc_z9ltxqgW2BUfl1BTtDQ3FOWIQ&usqp=CAU" Width= "30px"  runat="server" OnClick="ImageButton4_Click"/><br />
                    
            <br/>
             </div>
        </form>
  
    <div style="margin-left:50px; width: 165px; padding-top:25px; height: 0px;">
            <input type="button" id="b1" value="Home" onclick = "replace()"/>
            </div>
    <div style="margin-left:50px; width: 165px; padding-top:50px; height: 0px;">
            <input type="button" id="b2" value="Create" onclick = "replace1()"/>
            </div>
    <div style="margin-left:50px; width: 165px; padding-top:55px; height: 0px;">
            <input type="button" id="b3" value="MyCreate" onclick = "replace2()"/>
            </div>
    <div style="margin-left:50px; width: 165px; padding-top:55px; height: 0px;">
            <input type="button" id="b4" value="Power Bi" onclick = "window.location.href='https://app.powerbi.com/groups/me/apps/d19cff52-f173-420c-9209-09fa2dd134eb/reports/573c280a-bb81-4677-bd71-3c70af88af22/ReportSection?ctid=8d4b558f-7b2e-40ba-ad1f-e04d79e6265a';"/>
            </div>
    <div style="margin-left:50px; width: 165px; padding-top:55px; height: 0px;">
            <input type="button" id="b5" value="Approval List" onclick = "replace3()"/>
            </div>
    <div style="margin-left:50px; width: 165px; padding-top:130px; height: 0px;">
            <input type="button" id="b6" value="Logout" onclick="location.href = 'Default.aspx'"/>
            </div>
</body>
</html>

    <style type="text/css">
            
    #b1
    {
    background-color: #000000;
    color: #ffa500;
    width: 100%;
    font-size:20px;
    display: block;
    height: 40px;
    border-radius: 20px;
    transition: all 0.5s ease-in-out;
    border: none;
    
    }
    #b1:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #b1:focus {
        outline: none;
        color: #ffa500;
    }
    #b2
    {
    background-color: #000000;
    color: #ffa500;
    width: 100%;
    font-size:20px;
    display: block;
    height: 40px;
    border-radius: 20px;
    transition: all 0.5s ease-in-out;
    border: none;
   
    }
    #b2:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #b2:focus {
        outline: none;
        color: #ffa500;
    }
    #b3
    {
    background-color: #000000;
    color: #ffa500;
    width: 100%;
    font-size:20px;
    display: block;
    height: 40px;
    border-radius: 20px;
    transition: all 0.5s ease-in-out;
    border: none;
    
    }
    #b3:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #b3:focus {
        outline: none;
        color: #ffa500;
    }
    #b4
    {
    background-color: #000000;
    color: #ffa500;
    width: 100%;
    font-size:20px;
    display: block;
    height: 40px;
    border-radius: 20px;
    transition: all 0.5s ease-in-out;
    border: none;
    
    }
    #b4:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #b4:focus {
        outline: none;
        color: #ffa500;
    }
    #b5
    {
    background-color: #000000;
    color: #ffa500;
    width: 100%;
    font-size:20px;
    display: block;
    height: 40px;
    border-radius: 20px;
    transition: all 0.5s ease-in-out;
    border: none;
    
    }
    #b5:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #b5:focus {
        outline: none;
        color: #ffa500;
    }
    #b6
    {
    background-color: #000000;
    color: #ffa500;
    width: 100%;
    font-size:20px;
    display: block;
    height: 40px;
    border-radius: 20px;
    transition: all 0.5s ease-in-out;
    border: none;
    
    }
    #b6:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #b6:focus {
        outline: none;
        color: white;
    }
</style>