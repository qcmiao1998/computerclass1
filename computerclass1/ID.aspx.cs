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
            String ID = TextBox1.Text;
            //判断长度合法
            if (ID.Length != 18)
            {
                Returnfunc(1);
                return;
            }
            //判断有无非数字或末尾X
            if (Regex.IsMatch(ID,@"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$") == false)
            {
                Returnfunc(2);
                return;
            }


        }
        protected void Returnfunc (int back)
        {
            switch (back)
            {
                case 1: Response.Write("<script language='javascript'>alert('输入的位数错误')</script>");break;
                case 2: Response.Write("<script language='javascript'>alert('该身份证号码格式错误')</script>"); break;

            }

        }
    }
}