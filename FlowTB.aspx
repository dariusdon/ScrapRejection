<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlowTB.aspx.cs" Inherits="FlowTB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bead/Bentita</title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="margin-top:150px;margin-left:45%">
             <asp:Label ID="Label4" Font-Bold="true" Font-Size="35px" ForeColor="Orange" runat="server" Text="Pagina Selectie"></asp:Label>
             <br/>
             <br/>
            <div style="margin-left: -200px;">
                <asp:Button ID="Button1" runat="server" Text="Bentita" Width="600px" Height="150px" Font-Bold="true" Font-Size ="35px" OnClick="OnClick1"/>
                <br/>
                <br/>
                <asp:Button ID="Button2" runat="server" Text="Bead" Width="600px" Height="150px" Font-Bold="true" Font-Size ="35px" OnClick ="OnClick2"/>
                <br/>
                <br/>
               
            </div>
        </div>
    </form>
</body>
</html>
