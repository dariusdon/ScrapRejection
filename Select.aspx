﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Select.aspx.cs" Inherits="Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:100px;margin-top:20px">
            <asp:Label ID="Label1" Font-Bold="true" Font-Size="25px" ForeColor="Orange" runat="server" Text="Data:"></asp:Label>
            <br/>
            <asp:Label ID="Label2" Font-Bold="true" Font-Size="25px" ForeColor="Orange" runat="server" Text="Nume Operator:"></asp:Label>
            <br/>
            <asp:Label ID="Label3" Font-Bold="true" Font-Size="25px" ForeColor="Orange" runat="server" Text="Schimb:"></asp:Label>
        </div>

        <div style="margin-top:20px;margin-left:45%">
             <asp:Label ID="Label4" Font-Bold="true" Font-Size="35px" ForeColor="Orange" runat="server" Text="Pagina Selectie"></asp:Label>
             <br/>
             <br/>
            <div style="margin-left: -200px; margin-top:100px">
                <asp:Button ID="Button1" runat="server" Text="Scanare Masina TB" Width="600px" Height="150px" Font-Bold="true" Font-Size ="35px" OnClick="OnClick1"/>
                <br/>
                <br/>
                <asp:Button ID="Button2" runat="server" Text="Scanare Statie Rework" Width="600px" Height="150px" Font-Bold="true" Font-Size ="35px" OnClick ="OnClick2"/>
                <br/>
                <br/>
                 <asp:Button ID="Button3" runat="server" Text="Scanare Masina Apex/Bead" Width="600px" Height="150px" Font-Bold="true" Font-Size ="35px" OnClick ="OnClick3"/>
            </div>
        </div>
    </form>
</body>
</html>
