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
            long outnum = 1;
            for (int i = 1; i <= int.Parse(TextBox1.Text); i++)
            {
                outnum = outnum * i;
            }
            Response.Write(outnum.ToString());
        }
    }
}