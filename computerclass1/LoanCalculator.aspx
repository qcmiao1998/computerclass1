<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoanCalculator.aspx.cs" Inherits="computerclass1.LoanCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <table width="482" border="0">
            <tbody>
              <tr>
                <td width="153">贷款总额：</td>
                <td width="319">
                    <asp:TextBox ID="tbxTotal" runat="server"></asp:TextBox>
                    元</td>
              </tr>
              <tr>
                <td>年利率：</td>
                <td>
                    <asp:TextBox ID="tbxRate" runat="server"></asp:TextBox>
                    %</td>
              </tr>
              <tr>
                <td>月还款额：</td>
                <td>
                    <asp:TextBox ID="tbxEM" runat="server"></asp:TextBox>
                    元</td>
              </tr>
              <tr>
                <td colspan="2">
                    <asp:Button ID="btnCal" runat="server" Text="计算" Width="370px" OnClick="btnCal_Click" />
                  </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td>需还期限：</td>
                <td>
                    <asp:Label ID="LabelNumberofMonths" runat="server"></asp:Label>
                  </td>
              </tr>
              <tr>
                <td class="auto-style1">总还款额：</td>
                <td class="auto-style1">
                    <asp:Label ID="LabelTotalBack" runat="server"></asp:Label>
                  </td>
              </tr>
              <tr>
                <td>总利息：</td>
                <td>
                    <asp:Label ID="LabelTotalInterest" runat="server"></asp:Label>
                  </td>
              </tr>
              <tr>
                <td>最后月还款额：</td>
                <td>
                    <asp:Label ID="LabelLastMonth" runat="server"></asp:Label>
                  </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
            </tbody>
          </table>
        </div>
    </form>
</body>
</html>
