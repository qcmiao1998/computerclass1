using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace computerclass1
{
    public partial class output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Server.HtmlEncode( "茶叶");
            Response.Write("<script language='javascript'>alert('欢迎光临茶叶网站')</script>");
        }
    }
}