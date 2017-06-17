<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Bayes.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript" >
        function btnGuess_js() {
            return confirm("很有可能会猜错哦！\r\n你确定要猜吗？");
        }
    </script>
    <form id="form1" runat="server" defaultbutton="btnGuess">
    <div>
    
        Height: <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
        cm<br />
        Weight: <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
        kg<br />
        Foot-length: <asp:TextBox ID="txtFoot" runat="server"></asp:TextBox>
        cm<br />
        <asp:Button ID="btnGuess" runat="server" onclientclick="btnGuess_js()" 
            onclick="btnGuess_Click" Text="Calculate" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
