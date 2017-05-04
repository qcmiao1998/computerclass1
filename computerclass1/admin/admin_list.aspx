<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_list.aspx.cs" Inherits="computerclass1.admin.admin_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>管理员管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
             <tr>
                <td width="100%" bgcolor="#cccccc" height="5" ></td>
             </tr>
             <tr>
                <td width="100%" class="change_td" style="cursor:hand " >管理员管理</td>
             </tr>
        </table>   

        请选择院系<asp:DropDownList ID="ddldept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddldept_SelectedIndexChanged">
        </asp:DropDownList>
&nbsp;请输入关键字：<asp:TextBox ID="tbxkeyword" runat="server" AutoPostBack="True" OnTextChanged="tbxkeyword_TextChanged"></asp:TextBox>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="StudentNumber" HeaderText="ID" />
                <asp:BoundField DataField="StudentName" HeaderText="Username" />
                <asp:BoundField DataField="deptname" HeaderText="Deptname" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
                <asp:BoundField DataField="mobile" HeaderText="Mobile" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="birthday" HeaderText="Birthday" />
                <asp:BoundField DataField="logintimes" HeaderText="Logintimes " />
                <asp:HyperLinkField DataNavigateUrlFields="StudentNumber" DataTextField="StudentName" DataTextFormatString="修改" HeaderText="修改" />
                <asp:TemplateField HeaderText="删除">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" OnClientClick="return confirm ('Are you sure?');">删除</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </form>
</body>
</html>