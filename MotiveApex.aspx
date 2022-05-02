<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MotiveApex.aspx.cs" Inherits="MotiveApex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
            <p style="margin-left: 870px; font-size:40px; color: #ffa500; ">
            <asp:Label ID="Label1" runat="server" Text="Motive Apex:" CssClass ="label"></asp:Label>
            </p>
        </div>
        <div style="margin-left:150px;margin-top:-10px ">
           
                <asp:Button ID="Button1" runat="server" OnClick="OnClick1" Text="Imbinare Neconforma"   Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                
                <asp:Button ID="Button2" runat="server" OnClick="OnClick2" Text="Fir Sarma Iesit" Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                
                <asp:Button ID="Button7" runat="server" OnClick="OnClick3" Text="Fire Neacoperite"   Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                
                <asp:Button ID="Button8" runat="server" OnClick="OnClick4" Text="Pozitionare Neconforma" Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                <br />
                <br />
                
                <asp:Button ID="Button9" runat="server" OnClick="OnClick5" Text="Stationare Neconforma"   Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                
                <asp:Button ID="Button10" runat="server" OnClick="OnClick6" Text="Aer Intre Straturi" Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                
               
                <asp:Button ID="Button11" runat="server" OnClick="OnClick7" Text="Deformare TB" Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                
                <asp:Button ID="Button12" runat="server" OnClick="OnClick8" Text="Deformare Apex"  Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                 <br />
                 <br />

                <asp:Button ID="Button13" runat="server" OnClick="OnClick9" Text="Material Contaminat" Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
                
                <asp:Button ID="Button14" runat="server" OnClick="OnClick10" Text="Latimea Bentitei Neconforme"   Width="400px" Height="150px" Font-Bold="true" Font-Size ="26px"/>
                
                <asp:Button ID="Button15" runat="server" OnClick="OnClick11" Text="Diametru Gresit" Width="400px" Height="150px" Font-Bold="true" Font-Size ="30px"/>
               
                </div>
    </form>
</body>
</html>
