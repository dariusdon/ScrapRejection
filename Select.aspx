<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Select.aspx.cs" Inherits="Select" %>

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
            <div style="margin-left: -100px; margin-top:200px">
                <asp:Label style="margin-left:100px" Font-Size="30px" ForeColor="Orange" runat="server" Text="Scaneaza Masina:"></asp:Label>
                <br />
                <br />
                <asp:TextBox Font-Bold="true" style="margin-left:100px" ID="TextBox1" Width="200px" Font-Size="25px" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button style="margin-left:100px" ID="Button1" runat="server" Text="Salveaza" Width="210px" Height="50px" Font-Bold="true" Font-Size ="30px" OnClick="OnClick1"/>
                
            </div>
        </div>
    </form>
</body>
</html>
