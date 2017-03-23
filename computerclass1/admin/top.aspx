<%@ Page Language="C#" AutoEventWireup="true" CodeFile="top.aspx.cs" Inherits="admin_top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <table width="100%"  border="0" cellpadding="0" cellspacing="0">
  <tr>  
    <td width="263"><img src="image/website_top_1.gif" width="263" height="76"></td>
    <td width="100%" background="image/website_b.gif" valign="top"><br><br>&nbsp;<font color=white>→ 欢迎 
        <asp:Label ID="Admin_user" runat="server"></asp:Label>&nbsp; <b></b> 进入管理后台
    &nbsp;&nbsp;&nbsp;&nbsp;[<a href='logout.aspx' onclick="return admin_logout()" target="_top"><font color=white>退出管理</font></a>]    
    </font></td>
    <td width="323"></td>
  </tr> 
</table>
</body>
</html>
