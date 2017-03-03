using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace computerclass1
{
    public partial class ID : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            IDClass1 vid = new IDClass1();
            string outputwords = "Unknown ERROR";
            switch (vid.VerifyID(TextBox1.Text))
            {
                case 1: outputwords= "输入的位数错误"; break;
                case 2: outputwords= "该身份证号码格式错误"; break;

            }
            Response.Write("<script language='javascript'>alert('"+ outputwords +"')</script>");

        }
    }
}