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
    public partial class admin_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SQLHelper db = new SQLHelper();
            string sql = "select deptID,deptName from tblDept";
            db.RunSQL(sql);
            DataSet ds = new DataSet();
            db.RunSQL(sql, ref ds);
            ddldept.DataSource = ds.Tables[0];
            ddldept.DataTextField = "deptName";
            ddldept.DataValueField = "deptID";
            ddldept.DataBind();
        }
        protected void Btnadd_Click(object sender, EventArgs e)
        {
            string studentnumber = txtstudentnumber.Text;
            string name = txtname.Text;
            string password = txtpassword.Text;
            string mobile = txttelephonenumber.Text;
            string sex = DDLSex.Text;
            string birthday = txtbirthday.Text;
            string dept = ddldept.Text;
            string email = txtemail.Text;
            string gender = DDLSex.SelectedValue;
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] inputpwd = Encoding.Default.GetBytes(txtpassword.Text);
            byte[] outputpwd = md5.ComputeHash(inputpwd);
            password = BitConverter.ToString(outputpwd).Replace("-", "");
            if (studentnumber.Length != 11)
            {
                Response.Write("<script>alert('学号输入有误')</script>");
                return;
            }
            SQLHelper sh = new SQLHelper();
            string sql = "select max(studentID) from tblstudent";
            int ret = sh.RunSelectSQLToScalar(sql) + 1;
            string sqladd = string.Format("insert into TblStudent(StudentID,Studentname,StudentNumber,Password,gender,birthday,mobile,dept,email) values({0},'{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}')", ret, name, studentnumber, password, gender, birthday, mobile, dept, email);
            try
            {
                if (sh.RunSQL(sqladd) > 0)
                {
                    Response.Write("<script>alert('添加成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败')</script>");
                }
                sh.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

    }
}