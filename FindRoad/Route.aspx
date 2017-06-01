<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Route.aspx.cs" Inherits="FindRoad.Route" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose Start and End Point<br />
            Start：<asp:DropDownList ID="ddlStart" runat="server" Height="20px" Width="150px">
            </asp:DropDownList>
            <br />
            End：<asp:DropDownList ID="ddlEnd" runat="server" Height="20px" Width="150px">
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Calculate" />
            <br />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
