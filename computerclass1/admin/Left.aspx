<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Left.aspx.cs" Inherits="computerclass1.admin.Left" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>后台管理</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <script language="JavaScript" type="text/JavaScript">
    function showsubmenu(sid,sum)
    {
    whichEl = eval("submenu" + sid);
    if (whichEl.style.display == "none")
    {

    for (var i=0;i<=sum;i++)
    {
    if(i==sid)
    eval("submenu" + i + ".style.display=\"\";");
    else
    eval("submenu" + i + ".style.display=\"none\";");
    }
    }
    else
    {
    eval("submenu" + sid + ".style.display=\"none\";");
    }
    }
    </script>
</head>
<body>
    <table width="140" border="0" align="center" cellpadding="1" cellspacing="0">
      <tr>
        <td style="width: 141px">
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(0,10)"><div align="center"><font class="white">≡ 管理员管理 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"  id='submenu0'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_Admin.aspx" target="main" title="管理员管理" class="black_">管理员管理</a></td>
				      </tr>
				
				    </table>
			    </td>
	          </tr>
		    </table>
		    
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(1,10)"><div align="center"><font class="white">≡商品管理 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"  id='submenu1'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_ProductClass.aspx" target="main" title="商品分类管理" class="black_">商品分类管理</a></td>
				      </tr>
			
				    </table>
			    </td>
	          </tr>
		    </table>
		    
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(2,10)"><div align="center"><font class="white">≡ 新闻管理 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"  id='submenu2'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="Get_NewClass.aspx" target="main" title="新闻分类管理" class="black_">新闻分类管理</a></td>
				      </tr>
				
				    </table>
			    </td>
	          </tr>
		    </table>
	   
		    <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
		      <tr>
			    <td class="change_td" style="cursor:hand "  onClick="showsubmenu(3,10)"><div align="center"><font class="white">≡ 系统设置 ≡ </font></div></td>
		      </tr>
		      <tr style="display:none"   id='submenu3'>
		        <td>
				    <table width="98%"  border="0" align="center" cellpadding="0" cellspacing="0">
				      <tr>
					    <td bgcolor="#FFFFFF" height="25"><img src="image/dot_3.jpg" width="12" height="11">&nbsp;&nbsp;<a href="about.aspx" target="main" title="公司简介" class="black_">公司简介</a></td>
				      </tr>
		
				    </table>
			    </td>
	          </tr>
		    </table>  
	    </td>
      </tr>
      <tr>
        <td height="35" valign="top">
            <table width="100%" height="28"  border="0" cellpadding="4" cellspacing="1" bgcolor="#FFFFFF">
              <tr>
                <td height="28" class="change_td" style="cursor:hand ">〓 版权信息 〓</td>
              </tr>
              <tr>
                <td><p align="center"> CMS <span class="red12px">.net 2.0版</span>
                            </td>
              </tr>
            </table>
        </td>
      </tr>
</table>
</body>
</html>