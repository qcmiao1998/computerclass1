using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace computerclass1
{
    public partial class factorial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text=="")
            {
                Response.Write("请输入值");
                return;
            }
            ulong outnum = 1;
            for (uint i = 1; i <= uint.Parse(TextBox1.Text); i++)
            {
                outnum = outnum * i;
            }
            Response.Write(outnum.ToString());
        }
    }
}