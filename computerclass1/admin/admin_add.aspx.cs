using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;

namespace computerclass1.admin
{
    public partial class admin_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Btnadd_Click(object sender, EventArgs e)
        {
            string studentnumber = txtstudentnumber.Text;
            string name = txtname.Text;
            string password = txtpassword.Text;
            string mobile = txttelephonenumber.Text;
            string sex = DDLSex.Text;
            string birthday = txtbirthday.Text;
            string dept = txtdept.Text;
            string email = txtemail.Text;
            int gender = 0;
            if (studentnumber.Length != 11)
            {
                Response.Write("<script>alert('学号输入有误')</script>");
                return;
            }
            if (sex != "男" && sex != "女")
            {
                Response.Write("<script>alert('性别输入有误')</script>");
                return;
            }
            if (sex == "男")
                gender = 1;
            if (sex == "女")
                gender = 0;
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