

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="ChangeTool2._0.Create" %>

<!DOCTYPE html>
<link rel="stylesheet" href="CSS/CreateCSS.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 150px;
            width: 500px;
            margin-left: 0px;
        }
    </style>
</head>
<body style="padding-left: 100px;
    align-items: start;
    border-spacing: 10px;
    color: #000000;
    font-size: 16px;
    height: 95%;
    background-image: url(https://cdn.continental.com/fileadmin/__imported/sites/corporate/_international/english/hubpages/10_20press/01_press_releases/05_20plt/2021/continental_pp_sportcontact-7_1.jpg);
    background-repeat:no-repeat;
    
     position: fixed;
    background-size:cover;">
    
    <form id="form1" runat="server">
         <p style="margin-left: 650px; font-size:30px; color:white; width: 203px;"><u style="color:  #ffa500;">
                <asp:Label ID="Label2" runat="server" Text="Change Tool 2.0"></asp:Label>
                </u></p>
         <p style="margin-left: 500px; margin-top:-35px;font-size:30px; color:white; width: 600px;"><u style="color:#ffa500;">
                <asp:Label ID="Label13" runat="server" Text="Numar derogare/Deviation request:"></asp:Label>
                <asp:Label ID="Label15" runat="server" Text=""></asp:Label>
                </u></p>
        <%--<dreapta></dreapta>--%>
        <div style="float:right;margin-top:20px;margin-right:20px; width: 32%; height:950px;">
              <p style="color: white; font-size:20px; ">
                <asp:Label ID="Label20" runat="server" Text="Data de incheiere/End Date: "></asp:Label>
                <asp:TextBox ID="TextBox16" TextMode="Date"  Width="150px"  runat="server" CssClass="date"></asp:TextBox>
                <br />
                <br />
                 <asp:Label ID="Label5" runat="server" Text="Masina/Machine:"></asp:Label>
             <asp:TextBox ID="TextBox3" runat="server" CssClass="text" Height="20px" Width="172px"></asp:TextBox>
                  <br />
                  <br />
                 <asp:Label ID="Label1" runat="server" Text="Conditii principale/Main Conditions" ></asp:Label>
                 &nbsp;
                 <asp:DropDownList ID="DropDownList2" runat="server" Width ="347px" CssClass="select">
                 <asp:ListItem>Alege conditia /Select Condition</asp:ListItem>  
                 <asp:ListItem>Conditii de depozitare /Storage conditions </asp:ListItem>  
                 <asp:ListItem>Conditii de lucru(iluminat, scurgeri de apa) in restul cazurilor doar cu aprobare ESH / Working conditions (e.g. lighting, water leaks) in other cases only with the approval of the ESH department</asp:ListItem>  
                 <asp:ListItem>Material/produs expirat /Expired material or/and product according"Storage time" procedure</asp:ListItem>  
                 <asp:ListItem>Idenficarea materialului/produsului /Identification of material/product</asp:ListItem>  
                 <asp:ListItem>Parametrii de proces in afara tolerantelor/limitelor /Process parameters out of tolerance/limits</asp:ListItem>
                 <asp:ListItem>Valorile nominale ale produsului in conformitate cu HQST-V-MA-T-GD-SP-0084-01 “Components limits” /Product nominal values based on HQST-V-MA-T-GD-SP-0084-01 "Components limits"</asp:ListItem>
                     <asp:ListItem>Conditii de ambalare a materialului/produsului /Material/product packaging conditions</asp:ListItem>
                     <asp:ListItem>Aparate de masura si control expirate si / sau alte cazuri specifice (se va implica si departamentul de metrologie) / Expired measuring and control devices and / or other specific cases (the metrology will also be involved) </asp:ListItem>
                     <asp:ListItem>Verificari mentenanta intarziate/expirate (ex. MTC) /Delayed / expired maintenance checks (e.g., MTC)</asp:ListItem>
                     <asp:ListItem>Deviatii de la standardul sculelor/accesorile aferente utilajelor din cadrul fabricii /Deviations from the standard of tooling/ accessory related to plant equipments </asp:ListItem>
                     <asp:ListItem>Reprelucrarea materialelor/anvelope verzi/anvelope vulcanizate /Rework of materials/green tires/cured tires </asp:ListItem>
                     <asp:ListItem>Adaptarea retetei la RW/workoff  /RW/work off recipe adaptation</asp:ListItem>
                     <asp:ListItem>Componenta la/in afara limitei vs GUTS /Component at/out of limit vs GUTS</asp:ListItem>
                 </asp:DropDownList>
                 <br />
                 <p style="color: white; font-size:20px; padding-left: 0px">
                 <asp:Label ID="Label14" runat="server" Text="Please, select a file!"></asp:Label>
                 <asp:FileUpload ID="FileUpload1" runat="server" class="fileclass" />
                </p>
           
        <p style="color: white; font-size:20px; padding-left: 0px; margin-top:10px">
            <br />
            <asp:Label ID="Label18" runat="server" Text="Instructiuni Speciale/Special Instructions"></asp:Label><br />
                  <textarea ID="textarea3" style="width:330px; height:88px;" runat="server"></textarea>
            </p>
            
                 <p style="color: white; font-size: 20px; padding-left: 150px; margin-top:50px">

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <br />
            <asp:Label ID="Label16"  runat="server" Text="Informeaza pe/Inform:" BackColor="Black"></asp:Label>&nbsp
                     </p>
                    <br />
            <p style="color: white; font-size:20px; margin-left:-25px; margin-top:-10px; width: 224px;">
                <asp:ListBox ID="ListBox3" runat="server"  Font-Size="14px" Height="118px" Width="224px" SelectionMode="Multiple" style="margin-left: 0px;margin-top:-5px">
                    <asp:ListItem>adrian.canura@conti.de</asp:ListItem>
                    <asp:ListItem>adrian.cristea@conti.de</asp:ListItem>
                    <asp:ListItem>robert.szecsi@conti.de</asp:ListItem>
                    <asp:ListItem>claudiu.cercel@conti.de</asp:ListItem>
                    <asp:ListItem>sorin.popescu@conti.de</asp:ListItem>
                    <asp:ListItem>Gabriel.Olah@conti.de</asp:ListItem>
                    <asp:ListItem>jan.grobler@conti.de</asp:ListItem>
                    <asp:ListItem>serban.nicolescu@conti.de</asp:ListItem>
                    <asp:ListItem>paul.naglatzki@conti.de</asp:ListItem>
                    <asp:ListItem>matthieu.turlure@conti.de</asp:ListItem>
                    <asp:ListItem>antoine.poussin@conti.de</asp:ListItem>
                    <asp:ListItem>rodica.fintineanu@conti.de</asp:ListItem>
                    <asp:ListItem>Gabi.Mihoc@conti.de</asp:ListItem>
                    <asp:ListItem>elena.cornelia.rusanda@conti.de</asp:ListItem>
                    <asp:ListItem>simona.balajel@conti.de</asp:ListItem>
                    <asp:ListItem>florin.sechesan@conti.de</asp:ListItem>
                    <asp:ListItem>ovidiu.laurentiu.mallinger@conti.de</asp:ListItem>
                    <asp:ListItem>dan.popescu@conti.de</asp:ListItem>
                    <asp:ListItem>marian.craciun@conti.de</asp:ListItem>
                    <asp:ListItem>andrei.pavalasc@conti.de</asp:ListItem>
                    <asp:ListItem>mircea.boticiu@conti.de</asp:ListItem>
                    <asp:ListItem>andrei01.avram@conti.de</asp:ListItem>
                    <asp:ListItem>monica.boghian@conti.de</asp:ListItem>
                    <asp:ListItem>adrian.dragu@conti.de</asp:ListItem>
                    <asp:ListItem>florian.butac@conti.de</asp:ListItem>
                    <asp:ListItem>dragos.marcu@conti.de</asp:ListItem>
                    <asp:ListItem>eduard.kovacs@conti.de</asp:ListItem>
                    <asp:ListItem>adrian.feher@conti.de</asp:ListItem>
                    <asp:ListItem>raul.kovacs@conti.de</asp:ListItem>
                    <asp:ListItem>cristina.sturz@conti.de</asp:ListItem>
                    <asp:ListItem>sorin.toader@conti.de</asp:ListItem>
                    <asp:ListItem>constantin.sauleac@conti.de</asp:ListItem>
                    <asp:ListItem>sebastian.marian.decianu@conti.de</asp:ListItem>
                    <asp:ListItem>razvan.ioan.aoproae@conti.de</asp:ListItem>
                    <asp:ListItem>tiberiu.cristian.buleu@conti.de</asp:ListItem>
                    <asp:ListItem>Alin.Calin@conti.de</asp:ListItem>
                    <asp:ListItem>alin.belea@conti.de</asp:ListItem>
                    <asp:ListItem>Iancu.Marinel@conti.de</asp:ListItem>
                    <asp:ListItem>Ionel.Gana@conti.de</asp:ListItem>
                    <asp:ListItem>marius.toader@conti.de</asp:ListItem>
                    <asp:ListItem>darius-florin.don@conti.de</asp:ListItem>
                </asp:ListBox>
                <p style ="margin-left:275px; margin-top:-139px;">
                   <asp:ListBox ID="ListBox4" Font-Size="14px" runat="server" Height="118px" Width="224px" SelectionMode="Multiple">
                </asp:ListBox>
           </p>
            <p style ="margin-left:210px; margin-top:-130px">
                <asp:Button ID="Button10" Width="50px" Height="50px" runat="server" Text=">" Font-Bold="true" Font-Size="Large" OnClick="_Click3"/>
                <br />
            <p style="margin-left:210px">
                <p style ="margin-left:210px; margin-top:5px">
                <asp:Button ID="Button11" Width="50px" Height="50px" runat="server" Text="<" Font-Bold="true" Font-Size="Large" OnClick="_Click4"/>
                <br />
        </div>
        <%--/*centru*/--%>
        <div style="float:right;margin-top:20px;margin-right:20px; width: 33%; height:950px;">
            <p style="color:whitesmoke; font-size:20px; ">
                <asp:Label ID="Label21" runat="server" Text="Date de inceput/Start Date: "></asp:Label>
            <asp:TextBox ID="TextBox17" TextMode="Date" runat="server" Width="150px" CssClass="date"></asp:TextBox>
              <br />
                  <br />
            <asp:Label ID="Label4" runat="server" Text="Process/Department:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="text" Height="16px" Width="173px"></asp:TextBox>
             <br />
                 <br />
              <p style="color: ghostwhite; font-size: 20px; padding-left: 0px">
                 <asp:Label ID="Label9" runat="server" Text="Cantitate/Quantity:"></asp:Label>
            <asp:TextBox ID="TextBox10" runat="server" CssClass="text" Weight="100px" Height="16px" Width="186px"></asp:TextBox>
                 <br />
                  <br />
                  <br />
                  <br />
                
                 <asp:Label ID="Label7" runat="server" BackColor="Black" Text="Conditiile care au cauzat necesitatea de a fi creata cererea"></asp:Label>
                 <br/>
                  <asp:Label ID="Label10" runat="server" BackColor="Black" Text="The Conditions that caused the Deviation to be requested"></asp:Label>
                 
               <textarea ID = "textarea1" style="width:312px; height:91px;" runat="server"></textarea>
                 <br />
                 <br />
                  
                  </p>
             <p style="color: white; font-size: 20px; padding-left: 100px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            
        &nbsp;
        <p style="margin-left:-30px; margin-top:100px">
            <asp:Button ID="Button1" runat="server" Text="Create" Width="96%" OnClick="on_click" CssClass="signin"/>
           <%-- <br/> 
            <asp:UpdateProgress ID="update" Width="96%" runat="server"></asp:UpdateProgress>--%>
        </p>
            </div>
        
        <div  style="float:left;margin-top:20px;margin-left:-25px; width: 32%; height:950px;">
           
        <p style="color: white; font-size:20px; padding-left: 0px">
           
         <asp:Label ID="Label3" runat="server" Text="Creat de/Created By: "></asp:Label>
            <asp:TextBox ID="TextBox1"  runat="server" CssClass="text"  Width="231px"></asp:TextBox>
          
        <p style="color: white; font-size:18px; padding-left:0px">
        <asp:Label ID="Label6" runat="server" Text="Nr.doc. Poms si paragraful/ No. of PoMS document and paragraph: "></asp:Label>
        <asp:TextBox ID="TextBox9" OnLoad="Page_Load" runat="server" CssClass="text" Width="450px" Height="20px"></asp:TextBox>
           </p>
           
        <p style="color: white; font-size: 20px; padding-left: 0px">
            
             <asp:Label ID="Label8" runat="server" Text=" Codul sau descrierea produsului/ Code No. or description of the product:"></asp:Label>
             &nbsp;<asp:TextBox ID="TextBox6" runat="server" CssClass="text" Weight="100px" Height="16px" Width="170px"></asp:TextBox>
            
            

            <br />
            <br />
            <br />
           <p style="color: white; font-size:20px; padding-left: 0px">
                <asp:Label ID="Label17" runat="server" Text="Plan de actiune/Action plan"></asp:Label><br />
                 <textarea ID="textarea2" style="width:300px; height:88px;" runat="server"></textarea>
           
       
            <br />
            <br />
            <br />
            <p style="margin-left:100px; color: white; font-size: 20px;">
            <asp:Label ID="Label11"  runat="server" Text="Aprobator(i)/Approver(s)" BackColor="Black"></asp:Label>&nbsp <br/>
                 
           </p>
            <p style="color: white; font-size:20px; margin-left:-60px; width: 224px;">
                <asp:ListBox ID="ListBox1" runat="server" Height="118px" Width="224px" Font-Size="14px" SelectionMode="Multiple" >
                     <asp:ListItem>adrian.canura@conti.de</asp:ListItem>
                    <asp:ListItem>adrian.cristea@conti.de</asp:ListItem>
                    <asp:ListItem>robert.szecsi@conti.de</asp:ListItem>
                    <asp:ListItem>claudiu.cercel@conti.de</asp:ListItem>
                    <asp:ListItem>sorin.popescu@conti.de</asp:ListItem>
                    <asp:ListItem>Gabriel.Olah@conti.de</asp:ListItem>
                    <asp:ListItem>jan.grobler@conti.de</asp:ListItem>
                    <asp:ListItem>serban.nicolescu@conti.de</asp:ListItem>
                    <asp:ListItem>paul.naglatzki@conti.de</asp:ListItem>
                    <asp:ListItem>matthieu.turlure@conti.de</asp:ListItem>
                    <asp:ListItem>antoine.poussin@conti.de</asp:ListItem>
                    <asp:ListItem>rodica.fintineanu@conti.de</asp:ListItem>
                    <asp:ListItem>Gabi.Mihoc@conti.de</asp:ListItem>
                    <asp:ListItem>elena.cornelia.rusanda@conti.de</asp:ListItem>
                    <asp:ListItem>simona.balajel@conti.de</asp:ListItem>
                    <asp:ListItem>florin.sechesan@conti.de</asp:ListItem>
                    <asp:ListItem>ovidiu.laurentiu.mallinger@conti.de</asp:ListItem>
                    <asp:ListItem>dan.popescu@conti.de</asp:ListItem>
                    <asp:ListItem>marian.craciun@conti.de</asp:ListItem>
                    <asp:ListItem>andrei.pavalasc@conti.de</asp:ListItem>
                    <asp:ListItem>mircea.boticiu@conti.de</asp:ListItem>
                    <asp:ListItem>andrei01.avram@conti.de</asp:ListItem>
                    <asp:ListItem>monica.boghian@conti.de</asp:ListItem>
                    <asp:ListItem>adrian.dragu@conti.de</asp:ListItem>
                    <asp:ListItem>florian.butac@conti.de</asp:ListItem>
                    <asp:ListItem>dragos.marcu@conti.de</asp:ListItem>
                    <asp:ListItem>eduard.kovacs@conti.de</asp:ListItem>
                    <asp:ListItem>adrian.feher@conti.de</asp:ListItem>
                    <asp:ListItem>raul.kovacs@conti.de</asp:ListItem>
                    <asp:ListItem>cristina.sturz@conti.de</asp:ListItem>
                    <asp:ListItem>sorin.toader@conti.de</asp:ListItem>
                    <asp:ListItem>constantin.sauleac@conti.de</asp:ListItem>
                    <asp:ListItem>sebastian.marian.decianu@conti.de</asp:ListItem>
                    <asp:ListItem>razvan.ioan.aoproae@conti.de</asp:ListItem>
                    <asp:ListItem>tiberiu.cristian.buleu@conti.de</asp:ListItem>
                    <asp:ListItem>Alin.Calin@conti.de</asp:ListItem>
                    <asp:ListItem>alin.belea@conti.de</asp:ListItem>
                    <asp:ListItem>Iancu.Marinel@conti.de</asp:ListItem>
                    <asp:ListItem>Ionel.Gana@conti.de</asp:ListItem>
                    <asp:ListItem>marius.toader@conti.de</asp:ListItem>
                    <asp:ListItem>darius-florin.don@conti.de</asp:ListItem>
                </asp:ListBox>
                <p style ="margin-left:250px; margin-top:-139px">
                   <asp:ListBox ID="ListBox2" runat="server" Font-Size="14px" Height="118px" Width="224px" SelectionMode="Multiple">
                </asp:ListBox>
           </p>
            <p style ="margin-left:180px; margin-top:-130px">
                <asp:Button ID="Button4" Width="50px" Height="50px" autopostback="false" runat="server" Text=">" Font-Bold="true" Font-Size="Large" OnClick="_Click1"/>
                <br />
            <p style="margin-left:100px">
                <p style ="margin-left:180px; margin-top:5px">
                <asp:Button ID="Button5" Width="50px" Height="50px" autopostback="false" runat="server" Text="<" Font-Bold="true" Font-Size="Large" OnClick="_Click2"/>
                <br />
            
        </div>
      <style type="text/css">
          #ListBox1{
              font-size:15px;
              border-radius:0px;
              border-color:#ffa500;
          }

          #ListBox2{
              font-size:15px;
              border-radius:0px;
              border-color:#ffa500;
          }

      #loading {
          /*width: 100%;*/
          /*height: 100%;*/
          top: 0px;
          left: 0px;
          position: fixed;
          display: block;
          opacity: 0.7;
          background-color: #fff;
          
          text-align: center;
      }

          #loadingImage {
          position: absolute;
          top: 85px;
          left: 230px;
      }
          #Button4 {
    background-color: white;
    color: #ffa500;
   
   
    
    
    border-radius: 20px;
    
    transition: all 0.5s ease-in-out;
    border: none;
    text-transform: uppercase;
    font-weight: bold;
}

    #Button4:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #Button4:focus {
        outline: none;
        color: #ffa500;
    }

    #Button5 {
    background-color: white;
    color: #ffa500;
   
   
    
    
    border-radius: 20px;
    
    transition: all 0.5s ease-in-out;
    border: none;
    text-transform: uppercase;
    font-weight: bold;
}

    #Button5:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #Button5:focus {
        outline: none;
        color: #ffa500;
    }

    #Button2 {
    background-color: white;
    color: #ffa500;
   
   
    
    
    border-radius: 20px;
    
    transition: all 0.5s ease-in-out;
    border: none;
    font-weight: bold;
}

    #Button2:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #Button2:focus {
        outline: none;
        color: #ffa500;
    }
    #Button10 {
    background-color: white;
    color: #ffa500;
   
   
    
    
    border-radius: 20px;
    
    transition: all 0.5s ease-in-out;
    border: none;
    text-transform: uppercase;
    font-weight: bold;
}

    #Button10:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #Button10:focus {
        outline: none;
        color: #ffa500;
    }
    #Button11 {
    background-color: white;
    color: #ffa500;
   
   
    
    
    border-radius: 20px;
    
    transition: all 0.5s ease-in-out;
    border: none;
    text-transform: uppercase;
    font-weight: bold;
}

    #Button11:hover {
        background: #ffa500;
        box-shadow: 0 4px 35px -5px #000000;
        cursor: pointer;
        color: white;
        font-weight: bold;
    }

    #Button11:focus {
        outline: none;
        color: #ffa500;
    }
      </style>
  
    </form>
</body>
</html>
