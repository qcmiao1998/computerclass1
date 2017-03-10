using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace computerclass1
{
    public partial class triangle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = new int();
            try
            {
                num = int.Parse(TextBox1.Text);
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('请输入1到26的整数！')</script>");
                return;
            }
            if (num <= 0 || num > 26)
            {
                Response.Write("<script language='javascript'>alert('请输入1到26的整数！')</script>");
                return;
            }
            Response.Write("<tt>");
            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < num - i; j++)
                {
                    Response.Write("&ensp;");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    char word = (char)(64 + i);
                    Response.Write(word);
                }
                Response.Write("</br>");
            }
            Response.Write("</tt>");
        }
    }
}