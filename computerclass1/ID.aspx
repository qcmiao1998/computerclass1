<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ID.aspx.cs" Inherits="computerclass1.ID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入身份证号码：<asp:TextBox ID="TextBox1" runat="server" Width="297px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认" />
            <br />
            <br />
            户口所在地：<asp:Label ID="outputcity" runat="server"></asp:Label>
            <br />
            出生日期：<asp:Label ID="outputbirth" runat="server"></asp:Label>
            <br />
            性别：<asp:Label ID="outputgender" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
