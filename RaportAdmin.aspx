<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RaportAdmin.aspx.cs" Inherits="RaportAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 850px; font-size: 30px; color: #ffa500;">
            <br/>
            <asp:Label ID="Label1" runat="server" Text="Raport Scrap:" Font-Bold="true" ></asp:Label>
           
            <br/>
            <br/>
           
        </div>
        
              <asp:GridView ID="GridView1" Width="1600px" AllowPaging="true" Font-size="20px"  runat="server" HeaderStyle-BackColor="#ffa500" HeaderStyle-ForeColor="Black" PageSize="18"   >
         
         <PagerSettings mode="Numeric"
          position="Bottom"           
          pagebuttoncount="10" />
         <PagerStyle backcolor="#ffa500"
          height="30px"
          verticalalign="Bottom"
          horizontalalign="Right"/>
     </asp:GridView>
        

            
        
         <div>
             <p style="margin-top:20px;margin-left:100px">
                <asp:Label ID="Label6" ForeColor="Orange" Font-Size="20px" runat="server" Text="Raport Per Schimb"></asp:Label>
                <br/>
                <asp:Label ID="Label7" ForeColor="Orange" Font-Size="20px" runat="server" Text="De la Data Si Ora:"></asp:Label>
               &nbsp;&nbsp;
               <asp:TextBox ID="TextBox5" TextMode="Date"  Width="150px"  runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                 <asp:TextBox ID="TextBox6" TextMode="Time"  Width="150px"  runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Label ID="Label8" ForeColor="Orange" Font-Size="20px" runat="server" Text="Pana la Data Si Ora:"></asp:Label>
                 &nbsp;&nbsp;
               <asp:TextBox ID="TextBox7" TextMode="Date"  Width="150px"  runat="server"></asp:TextBox>
                  &nbsp;&nbsp;
                 <asp:TextBox ID="TextBox8" TextMode="Time" Width="150px"  runat="server"></asp:TextBox>
                  &nbsp;&nbsp;&nbsp;
                 <asp:DropDownList ID="DropDownList1" Font-Size="20px" runat="server" Height="30px" Width="146px">
                      <asp:ListItem Text= "Schimb1" Value="Schib1"></asp:ListItem>
                     <asp:ListItem Text= "Schimb2" Value="Schimb2"></asp:ListItem>
                    <asp:ListItem Text= "Schimb3" Value="Schimb3"></asp:ListItem>
                    
                 </asp:DropDownList>
                &nbsp;&nbsp;
                <asp:Button ID="Button2" Font-Bold="true" Font-Size="20px" runat="server" Text="Genereaza Schimb" />
             </p>
             <p style="margin-top:20px;margin-left:100px">
                <asp:Label ID="Label2" ForeColor="Orange" Font-Size="20px" runat="server" Text="Raport General"></asp:Label>
                <br/>
                <asp:Label ID="Label3" ForeColor="Orange" Font-Size="20px" runat="server" Text="De la Data Si Ora:"></asp:Label>
               &nbsp;&nbsp;
               <asp:TextBox ID="TextBox2" TextMode="Date"  Width="150px"  runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                 <asp:TextBox ID="TextBox3" TextMode="Time"  Width="150px"  runat="server"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:Label ID="Label4" ForeColor="Orange" Font-Size="20px" runat="server" Text="Pana la Data Si Ora:"></asp:Label>
                 &nbsp;&nbsp;
               <asp:TextBox ID="TextBox4" TextMode="Date"  Width="150px"  runat="server"></asp:TextBox>
                  &nbsp;&nbsp;
                 <asp:TextBox ID="TextBox9" TextMode="Time" Width="150px"  runat="server"></asp:TextBox>
                  &nbsp;&nbsp;
                <asp:Button ID="Button1" Font-Bold="true" Font-Size="20px" runat="server" Text="Genereaza Raport"/>
                 <br/>
                 <asp:Label ID="Label5" ForeColor="Orange" Font-Size="20px" runat="server" Text=""></asp:Label>
             </p>
        </div>
    </form>
</body>
</html>
