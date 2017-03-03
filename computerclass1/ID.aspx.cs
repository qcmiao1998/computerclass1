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
            string ID = TextBox1.Text;
            IDClass1 vid = new IDClass1();

            //检查有无问题
            string outputwords = "";
            switch (vid.VerifyID(ID))
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
            //获取信息并输出
            string hometown;
            DateTime birthday;
            bool gender;
            vid.GetIDinfo(ID, out hometown, out birthday, out gender);
            outputcity.Text = hometown;
            outputbirth.Text = birthday.ToLongDateString().ToString();
            if (gender==true)
            {
                outputgender.Text = "男";
            }
            else
            {
                outputgender.Text = "女";
            }

        }
    }
}