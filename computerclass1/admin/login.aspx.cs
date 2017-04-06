using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace computerclass1.admin
{
    public partial class login : System.Web.UI.Page
    {
        static string sValidator = "";
        private readonly string sValidatorImageUrl = "ValidateImage.aspx?Validator=";
        private Random random;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                random = new Random();
                sValidator = random.Next(100000, 999999).ToString();
                ValidateImage.ImageUrl = sValidatorImageUrl + sValidator;
            }

        }
            protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxValidate.Text !=sValidator )
            {
                Response.Write("<script language='javascript'>alert ('验证码错误')</script>");
                return;
            }
            if (tbxUsername.Text=="test" && tbxPwd.Text=="test")
            {
                Response.Redirect ("default.aspx");
            }
            else
            {
                Response.Write("<script language='javascript'>alert ('用户名密码错误')</script>");
            }
        }
    }
}