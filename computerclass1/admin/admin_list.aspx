<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_list.aspx.cs" Inherits="computerclass1.admin.admin_list" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>管理员管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            background-color: #356397;
            color: #ffffff;
            font-weight: bold;
            cursor: hand;
            height: 23px;
        }
        .auto-style4 {
            font-size: medium;
        }
        .auto-style5 {
            text-align: center;
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
                <td width="100%" class="auto-style1" >管理员管理</td>
             </tr>
        </table>   
        <table width="98%" border="0" cellpadding="3" align="center" cellspacing="0">
            <tr>
                <td width="100%">

                    <span class="auto-style4">Choose Dept:</span> <asp:DropDownList ID="ddldept" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddldept_SelectedIndexChanged" CssClass="auto-style4">
        </asp:DropDownList>
&nbsp;<span class="auto-style4">Keyword:</span> <asp:TextBox ID="tbxkeyword" runat="server" AutoPostBack="True" OnTextChanged="tbxkeyword_TextChanged" CssClass="auto-style4"></asp:TextBox>

        &nbsp;<asp:Button ID="btnsearch" runat="server" OnClick="btnsearch_Click" Text="Search" CssClass="auto-style4" />

                    <span class="auto-style4">&nbsp;<asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Choose All" />
&nbsp;</span><asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />

                    <div class="auto-style5">

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" Width="100%" CssClass="auto-style4" DataKeyNames="StudentID" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Choose">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="StudentNumber" HeaderText="ID" />
                <asp:BoundField DataField="StudentName" HeaderText="Username" />
                <asp:BoundField DataField="deptname" HeaderText="Deptname" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
                <asp:BoundField DataField="mobile" HeaderText="Mobile" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:BoundField DataField="birthday" HeaderText="Birthday" DataFormatString="{0:MM/dd/yyyy}" />
                <asp:BoundField DataField="logintimes" HeaderText="Logintimes " />
                <asp:HyperLinkField DataNavigateUrlFields="StudentID" DataTextField="StudentName" DataTextFormatString="Modify" HeaderText="Modify" DataNavigateUrlFormatString="admin_add.aspx?sid={0}" />
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete" OnClientClick="return confirm ('Are you sure?');">删除</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
                    </div>

                </td>
            </tr>
        </table>
        <br />

        <div class="auto-style5">
        </div>
    </form>
</body>
</html>