using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

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
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] inputpwd = Encoding.Default.GetBytes(tbxPwd.Text);
            byte[] outputpwd = md5.ComputeHash(inputpwd);
            if (tbxValidate.Text !=sValidator )
            {
                Response.Write("<script language='javascript'>alert ('验证码错误')</script>");
                return;
            }
            try
            {
                userdb.RunSQL(sql ,out sdr);
                
                
            }
            catch (Exception err)
            {
                userdb.Close();
                Response.Write(string.Format("Error. {0}", err.Message));
                return;
            }
            if (sdr.Read())
            {
                pwd = sdr.GetString(0);
                if (BitConverter.ToString(outputpwd).Replace("-", "") == pwd)
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
            userdb.Close();
        }
    }
}