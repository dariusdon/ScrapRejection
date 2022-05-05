<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MasinaAPEX.aspx.cs" Inherits="MasinaAPEX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parametrii Apex</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="margin-left:45%;margin-top:20px;">
                <asp:Label ID="Label4" runat="server" Font-Bold="true" Font-Size="35px" ForeColor="Orange" Text="Selecteaza Parametrii:"></asp:Label>
            </p>
            <p style="margin-left:200px;margin-top:200px">
                <asp:Label ID="Label1" runat="server" Font-Bold="true" Font-Size="25px" ForeColor="Orange" Text="Selecteaza Numar Toli:"></asp:Label>
                <asp:DropDownList ID="DropDownList1"  Font-Size="25px" BackColor="Orange" ForeColor="Black" runat="server">
                    <asp:ListItem Text="Numar Toli"></asp:ListItem>
                    <asp:ListItem Text="13" Value ="13"></asp:ListItem>
                    <asp:ListItem Text="14" Value ="14"></asp:ListItem>
                    <asp:ListItem Text="15" Value ="15"></asp:ListItem>
                    <asp:ListItem Text="16" Value ="16"></asp:ListItem>
                    <asp:ListItem Text="17" Value ="17"></asp:ListItem>
                    <asp:ListItem Text="18" Value ="18"></asp:ListItem>
                    <asp:ListItem Text="19" Value ="19"></asp:ListItem>
                    <asp:ListItem Text="20" Value ="20"></asp:ListItem>
                </asp:DropDownList>
                <br/>
                <br/>
                <br/>
                <br/>
                <asp:Label ID="Label2" runat="server" Font-Bold="true" Font-Size="25px" ForeColor="Orange" Text="Selecteaza Profil:"></asp:Label>
                <asp:DropDownList ID="DropDownList2" Font-Size="25px" BackColor="Orange" ForeColor="Black" runat="server" Width="100px">
                <asp:ListItem Text="Profil"></asp:ListItem>
                </asp:DropDownList>
                <br/>
                <br/>
                <br/>
                <br/>
                <asp:Label ID="Label3" runat="server" Font-Bold="true" Font-Size="25px" ForeColor="Orange" Text="Introducere Numar Bucati:"></asp:Label>
                <asp:TextBox ID="TextBox1" Font-Size ="25px"  runat="server" Width="118px"></asp:TextBox>
            </p>
            <p style="margin-left:49%;margin-top:300px">
                <asp:Button ID="Button1" Font-Size="30px"  runat="server" Text="Salveaza" OnClick="OnClick1"/>
            </p>
        </div>
    </form>
</body>
</html>
