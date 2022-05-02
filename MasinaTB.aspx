<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MasinaTB.aspx.cs" Inherits="MasinaTB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
            
        <div style="margin-top:200px;margin-left:37%">
             <asp:Label ID="Label4" Font-Bold="true" Font-Size="35px" ForeColor="Orange" runat="server" Text="Selecteaza Bentita/Bead:"></asp:Label>
             <br/>
             <br/>
            <div style="margin-left: -120px;">
                <asp:Button ID="Button1" runat="server" Text="Bead" Width="600px" Height="150px" Font-Bold="true" Font-Size ="35px" OnClick="OnClick1"/>
                <br/>
                <br/>
                <br/>
                <asp:Button ID="Button2" runat="server" Text="Bentita" Width="600px" Height="150px" Font-Bold="true" Font-Size ="35px" OnClick ="OnClick2"/>
                
                
            </div>
        </div>
       
    </form>
</body>
</html>
