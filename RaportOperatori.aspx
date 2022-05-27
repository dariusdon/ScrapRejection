<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RaportOperatori.aspx.cs" Inherits="RaportOperatori" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div style="margin-left: 750px; font-size: 35px; color: #ffa500;">
            <br/>
            <asp:Label ID="Label1" runat="server" Text="Raport Scrap Apex:" Font-Bold="true" ></asp:Label>
           
            <br/>
            <br/>
           
        </div>
  
     <div style="margin-top:50px; margin-left:100px">
              <asp:GridView ID="GridView1" OnPageIndexChanging="GrdEmp_PageIndexChanging" Width="1700px" AllowPaging="true" Font-size="20px"  runat="server" HeaderStyle-BackColor="#ffa500" HeaderStyle-ForeColor="Black" PageSize="20" style="margin-right: 0px">
         
         <PagerSettings mode="Numeric"
          position="Bottom"           
          pagebuttoncount="10" />
         <PagerStyle backcolor="#ffa500"
          height="20px"
          verticalalign="Bottom"
          horizontalalign="Right"/>
     </asp:GridView>
        </div>
        <div style="margin-top:50px;margin-left:650px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" Font-Bold="true" Font-Size="20px" runat="server" Text="Alta Colectare" OnClick="OnClick1"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2"  Font-Bold="true" Font-Size="20px" runat="server" Text="Inchide Colectare" OnClick="OnClick2"/>
        </div>
    </form>
</body>
</html>
