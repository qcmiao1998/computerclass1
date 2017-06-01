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
    public partial class admin_add : BasePage
    {
        private bool ismodify;
        private string sid;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["sid"] == null)
            {
                ismodify = false;
            }
            else
            {
                ismodify = true;
            }
            if (!IsPostBack)
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

                if (Request.Params["sid"] != null)
                {
                    sid = Request.Params["sid"];
                    ismodify = true;
                    Btnadd.Text = "Modify";
                    txtpassword.Enabled = false;
                    txtpasswordagain.Enabled = false;
                    string sql1 = "select * from tblstudent where studentid =" + sid;
                    SqlDataReader sdr;
                    SQLHelper sh = new SQLHelper();
                    try
                    {
                        sh.RunSQL(sql1, out sdr);
                        if (sdr.Read())
                        {
                            txtbirthday.Text = ((DateTime)sdr["birthday"]).ToString();
                            txtstudentnumber.Text = sdr["studentnumber"].ToString();
                            txtname.Text = sdr["studentname"].ToString();
                            txtemail.Text = sdr["email"].ToString();
                            txttelephonenumber.Text = sdr["mobile"].ToString();
                            ddldept.Items.FindByValue(sdr["dept"].ToString()).Selected = true;
                            DDLSex.Items.FindByValue(sdr["gender"].ToString() == "True" ? "1" : "0").Selected = true;
                        }
                        sh.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write(string.Format("<script>alert('Error. {0}')</script>", ex.Message));
                        return;
                    }
                }
            
            }
        }
        protected void Btnadd_Click(object sender, EventArgs e)
        {
            if (ismodify==false)
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
                string sql1 = "select max(studentID) from tblstudent";
                int ret = sh.RunSelectSQLToScalar(sql1) + 1;
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
            else
            {
                sid = Request.Params["sid"];
                string sql2 = string.Format("UPDATE [dbo].[TblStudent] SET [StudentName] = '{1}' ,[Gender] = '{2}' ,[Birthday] = '{3}' ,[Mobile] = '{4}' ,[Dept] = {5} ,[Email] = '{6}' WHERE [StudentID] = {0}", sid, txtname.Text, DDLSex.SelectedValue, txtbirthday.Text, txttelephonenumber.Text, ddldept.SelectedValue, txtemail.Text);
                SQLHelper sh = new SQLHelper();
                try
                {
                    if (sh.RunSQL(sql2) > 0)
                    {
                        sh.Close();
                        Response.Write("<script>alert('Success!');window.location.href='admin_list.aspx'</script>");
                    }
                }
                catch (Exception eee)
                {
                    Response.Write(string.Format("<script>alert('Error: {0}')</script>",eee.Message));
                    return;
                }
            }
            
        }

    }
}