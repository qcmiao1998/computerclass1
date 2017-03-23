<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="admin_Main" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <table width="98%"  border="0" cellpadding="3" align="center" cellspacing="0" bgcolor="#F1EAE0">
             <tr>
                <td width="100%" bgcolor="#cccccc" height="5" ></td>
             </tr>
             <tr>
                <td width="100%" class="change_td" style="cursor:hand " >服务器参数</td>
             </tr>
        </table> 
    <table cellspacing="1" cellpadding="3" width="98%" align="center"  bgColor="#ffffff" border="0">
          <tbody>
          <tr>
            <td class="th1" align="center" colSpan=2 style="height: 25px">服务器信息统计 </td></tr>
          <tr bgColor="#f9fbf0">
            <td width="50%" style="height: 24px">&nbsp;<strong>服务器名</strong>：</td>
            <td width="50%" style="height: 24px">&nbsp;<b>服务器端口：</b></td></tr>
          <tr bgColor="#f9fbf0">
            <td width="50%" style="height: 23px">&nbsp;<b>脚本解释引擎：</b></td>
            <td width="50%" style="height: 23px"><b>&nbsp;站点物理路径：</b>/td></tr>
          <tr bgColor="#f9fbf0">
            <td width="50%" style="height: 23px">&nbsp;<b>服务器CPU个数：</b></td>
            <td width="50%" style="height: 23px">&nbsp;<b>服务器IIS版本：</b></td></tr>
          <tr bgColor="#f9fbf0">
            <td width="50%">&nbsp;<b>开机运行时长</b>：  小时
            </td>
            <td width="50%"><b>&nbsp;服务器时间：</b></td></tr>
          <tr bgColor="#f9fbf0">
            <td colspan="2">&nbsp;<b>服务器操作系统：</b><span> </span> </td>
            </tr>
              <tr bgcolor="#f9fbf0">
                  <td colspan="2">&nbsp;
                  </td>
              </tr>
          </tbody>
        </table>
      
    </form>
</body>
</html>
