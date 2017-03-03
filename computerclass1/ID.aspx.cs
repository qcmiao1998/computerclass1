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

            //检查有无问题
            string outputwords = "";
            switch (vid.VerifyID(TextBox1.Text))
            {
                case 1: outputwords = "输入的位数错误"; break;
                case 2: outputwords = "该身份证号码格式错误"; break;
                case 3: outputwords = "校验位不正确，请检查输入的身份证号码是否有误"; break;
            }
            if (outputwords != "" )
            {
                Response.Write("<script language='javascript'>alert('" + outputwords + "')</script>");
                return;
            }
            

        }
    }
}