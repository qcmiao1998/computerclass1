<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_add.aspx.cs" Inherits="computerclass1.admin.admin_add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加管理员</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
         <tr>
            <td width="100%" bgcolor="#cccccc" height="5" ></td>
         </tr>
         <tr>
            <td width="100%" class="change_td" style="cursor:hand " >添加管理员</td>
         </tr>
    </table> 
    <table width="98%"  border="0" align="center" cellpadding="3" cellspacing="1" bgcolor="cccccc">         
		  <tr bgcolor="#eeeeee">
            <td width="20%" align="right">后台登录名称：&nbsp;</td>
            <td width="80%">
                <asp:TextBox ID="tbxusername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbxusername" ErrorMessage="必须输入登录名称" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
		  </tr>
          <tr bgcolor="#eeeeee">
            <td align="right">后台登录密码：&nbsp;</td>
            <td>
                <asp:TextBox ID="tbxpwd" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbxpwd" ErrorMessage="必须输入登录密码" ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr bgcolor="#eeeeee">
            <td align="right">&nbsp;</td>
            <td>
                <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="ADD" />
              </td>
          </tr>
</table>
 
    </form>
</body>
</html>
