<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="computerclass1.admin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理员登录</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
    <!--
    body {
	    background-image: url(image/beijing.gif);
	    margin-left: 0px;
	    margin-top: 0px;
	    margin-right: 0px;
	    margin-bottom: 0px;
    }
    .style1 {
	    font-size: 20px;
	    color: #FFFFFF;
	    font-family: "方正综艺简体";
    }
    -->
    </style>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
</head>

<body>
    <form id="form1" runat="server">
    <table width="1004" height="603" border="0" cellpadding="0" cellspacing="0">   
    <tr>
    <td style="width: 419px"><div align="right"><img src="image/pic01.gif" width="216" height="301" border="0" ></div></td>
    <td valign="top" style="width: 393px"><table width="100%"  border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="393" height="151" valign="top">&nbsp;</td>
      </tr>
      <tr>
        <td width="393" height="301" valign="middle" background="image/pic02.gif"><div align="center">
          <table width="100%"  border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td style="height: 30px; width: 182px;"><div align="right" class="unnamed1">&nbsp; 用户名:&nbsp;&nbsp; </div></td>
              <td width="55%" style="height: 30px"> 
             <div align="left">
                  &nbsp;<asp:TextBox ID="tbxUsername" runat="server"></asp:TextBox>
                  </div></td>
            </tr>
            <tr>
              <td style="width: 182px; height: 19px"><div align="right" class="unnamed1">密&nbsp; 码:&nbsp;&nbsp; </div></td>
              <td style="height: 19px"><div align="left">
                  &nbsp;<asp:TextBox ID="tbxPwd" runat="server" TextMode="Password"></asp:TextBox>
                  </div></td>
            </tr>
            <tr>
              <td height="30" style="width: 182px"><div align="right">
                  <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
                &nbsp;</div></td>
              <td height="30"><div align="left"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  <asp:Button ID="btnReset" runat="server" Text="Reset" />
            </div></td>
            </tr>
          </table>
          </div></td>
      </tr>
      <tr>
        <td style="height: 19px"></td>
      </tr>
    </table></td>
    <td width="192">&nbsp;</td>
  </tr>
</table>
    </form>
</body>
</html>
