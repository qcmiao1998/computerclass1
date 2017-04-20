using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;
using System.Data.SqlClient;

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
            SQLHelper userdb = new SQLHelper();
            string pwd;
            SqlDataReader sdr;
            string sql = string.Format("select Password from tblstudent where StudentNumber = '{0}' ", tbxUsername.Text);
            if (tbxValidate.Text !=sValidator )
            {
                Response.Write("<script language='javascript'>alert ('验证码错误')</script>");
                return;
            }
            try
            {
                userdb.RunSQL(sql ,out sdr);
                userdb.Close();
                
            }
            catch (Exception err)
            {
                Response.Write(string.Format("Error. {0}", err.Message));
                return;
            }
            if (sdr.Read())
            {
                pwd = sdr.GetString(0);
                if (tbxPwd.Text == pwd)
                {
                    Response.Redirect("default.aspx");
                }
                else
                {
                    Response.Write("<script language='javascript'>alert ('密码错误')</script>");
                }
            }
            else
            {
                Response.Write("<script language='javascript'>alert ('用户名错误')</script>");
            }
        }
    }
}