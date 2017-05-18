<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_add.aspx.cs" Inherits="computerclass1.admin.admin_add" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>添加管理员</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style16
        {
            height: 29px;
        }
    </style>
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
		  <tr>
            <td width="20%" align="right" class="style16">后台登录名称（学号）：</td>
            <td width="80%">
                <asp:TextBox ID="txtstudentnumber" runat="server" TextMode="Number" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="Validatorstudentnumber" runat="server" 
                    ControlToValidate="txtstudentnumber" ErrorMessage="*必须填写此项(长度为11）" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
		  </tr>
          <tr>
            <td align="right" class="style17">姓名：</td>
            <td class="style18">
                <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="Validatorname" runat="server" 
                    ControlToValidate="txtname" ErrorMessage="*必须填写此项" ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
            <td align="right" class="style16">后台登录密码：</td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ValidatorPassWord" runat="server" 
                    ControlToValidate="txtpassword" ErrorMessage="*必须填写此项" ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
            <td align="right" class="style16">再次确认密码：</td>
            <td>
                <asp:TextBox ID="txtpasswordagain" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ValidatorPassWordagain" runat="server" 
                    ControlToValidate="txtpasswordagain" ErrorMessage="*必须填写此项" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
                &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtpassword" ControlToValidate="txtpasswordagain" 
                    ErrorMessage="*两次输入不一致" ForeColor="Red"></asp:CompareValidator>
              </td>
          </tr>
          <tr>
            <td align="right" class="style16">手机：</td>
            <td>
                <asp:TextBox ID="txttelephonenumber" runat="server" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ValidatorPasstelephonenumber" runat="server" 
                    ControlToValidate="txttelephonenumber" ErrorMessage="*必须填写此项" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
              &nbsp;<asp:RegularExpressionValidator 
                    ID="RegularExpressionValidatortelephonenumber" runat="server" ControlToValidate="txttelephonenumber" 
                    ValidationExpression="(\(\d{3}\)|\d{3}-)?\d{8}"   ErrorMessage="*手机号码格式错误!" 
                    ForeColor="Red"></asp:RegularExpressionValidator>
              </td>
          </tr>
          <tr>
            <td align="right" class="style16">性别：</td>
            <td>
                <asp:DropDownList ID="DDLSex" runat="server">
                    <asp:ListItem Value="1">男</asp:ListItem>
                    <asp:ListItem Value="0">女</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="Validatorsex" runat="server" 
                    ControlToValidate="DDLSex" ErrorMessage="*必须填写此项" ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
            <td align="right" class="style16">出生日期：</td>
            <td>
                <asp:TextBox ID="txtbirthday" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="Validatorbirthday" runat="server" 
                    ControlToValidate="txtbirthday" ErrorMessage="*（YYYY/MM/DD)必须填写此项" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
            <td align="right" class="style16">院系：</td>
            <td class="style16">
                <asp:DropDownList ID="ddldept" runat="server" Height="17px" Width="188px">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="Validatordept" runat="server" 
                    ControlToValidate="ddldept" ErrorMessage="*必须填写此项" ForeColor="Red"></asp:RequiredFieldValidator>
              </td>
          </tr>
          <tr>
            <td align="right" class="style16">电子邮件：</td>
            <td>
                <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="Validatoremail" runat="server" 
                    ControlToValidate="txtemail" ErrorMessage="*必须填写此项" ForeColor="Red"></asp:RequiredFieldValidator>
              &nbsp;<asp:RegularExpressionValidator 
                    ID="RegularExpressionValidatortelephonenumber0" runat="server" ControlToValidate="txtemail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"   
                    ErrorMessage="*电子邮件格式错误!" ForeColor="Red"></asp:RegularExpressionValidator>
              </td>
          </tr>
          <tr bgcolor="#eeeeee">
            <td align="right">&nbsp;</td>
            <td>
                <asp:Button ID="Btnadd" runat="server" onclick="Btnadd_Click" Text="添加" 
                    style="width: 40px" />
              </td>
          </tr>
</table>
 
    </form>
</body>
</html>