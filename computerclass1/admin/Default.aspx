<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="admin_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<frameset rows="69,*" cols="*" frameborder="no" border="0" framespacing="0">
  <frame src="top.aspx" name="topFrame" scrolling="no" noresize>
  <frameset rows="*" cols="180,*" framespacing="0" frameborder="no" border="0">
    <frame src="Left.aspx" MarginWidth="0" name="leftFrame" scrolling="yes" noresize >
     <frame src="Main.aspx" name="main">
  </frameset>
</frameset>
<noframes><body>
</body></noframes>
</html>
