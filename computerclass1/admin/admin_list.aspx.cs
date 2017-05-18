using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;
using System.Data;
using System.Data.SqlClient;

namespace computerclass1.admin
{
    public partial class admin_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Deptddlbinddate();
                Gridviewbinddate();
            }
        }
        protected void btnsearch_Click(object sender, EventArgs e)
        {
            if (ddldept.SelectedValue == "0" && tbxkeyword.Text == "")
            {
                Response.Write("<script>alert('请输入查找条件');</script>");
                Gridviewbinddate();
                return;
            }
            search(ddldept.SelectedValue, tbxkeyword.Text);
        }
        protected void ddldept_SelectedIndexChanged(object sender, EventArgs e)
        {
            search(ddldept.SelectedValue, tbxkeyword.Text);
        }

        protected void tbxkeyword_TextChanged(object sender, EventArgs e)
        {
            search(ddldept.SelectedValue, tbxkeyword.Text);
        }
        private void Gridviewbinddate()
        {
            DataSet ds = new DataSet();
            SQLHelper sh = new SQLHelper();
            string sql = "select studentID,studentnumber,studentname,case gender when'1' then '男' when'0' then'女' end as gender,birthday,mobile,deptname,email,logintimes from tblstudent inner join tbldept on tblstudent.dept=tbldept.deptID";
            sh.RunSQL(sql, ref ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            sh.Close();
        }
        private void Deptddlbinddate()
        {
            DataSet ds = new DataSet();
            SQLHelper sh = new SQLHelper();
            string sql = "select deptID,deptName from tblDept";
            sh.RunSQL(sql, ref ds);
            ddldept.DataSource = ds.Tables[0];
            ddldept.DataTextField = "deptname";
            ddldept.DataValueField = "deptID";
            ddldept.DataBind();
            ddldept.Items.Add(new ListItem("Unselected", "0"));
            ddldept.SelectedIndex = ddldept.Items.IndexOf(ddldept.Items.FindByValue("0"));
        }
        private void search(string dept,string keyword)
        {
            string sql;
            if (ddldept.SelectedValue == "0" && tbxkeyword.Text == "")
            {
                Gridviewbinddate();
                return;
            }
            else if (dept=="0")
            {
                sql = string.Format("select studentID,studentnumber,studentname,case gender when'1' then '男' when'0' then'女' end as gender,birthday,mobile,deptname,email,logintimes from tblstudent inner join tbldept on tblstudent.dept=tbldept.deptID where studentID like '%{1}%'or studentnumber like '%{1}%'or studentname like '%{1}%'or gender like '%{1}%'or birthday like '%{1}%'or mobile like '%{1}%'or deptname like '%{1}%'or email like '%{1}%'or logintimes like '%{1}%'",dept,keyword);
            }
            else if (keyword=="")
            {
                sql = string.Format("select studentID, studentnumber, studentname,case gender when'1' then '男' when'0' then'女' end as gender, birthday, mobile, deptname, email, logintimes from tblstudent inner join tbldept on tblstudent.dept = tbldept.deptID where dept = '{0}'",dept,keyword);
            }
            else
            {
                sql = string.Format("select studentID,studentnumber,studentname,case gender when'1' then '男' when'0' then'女' else '数据错误' end as gender,birthday,mobile,deptname,email,logintimes from tblstudent inner join tbldept on tblstudent.dept=tbldept.deptID where dept='{0}' and (studentID like '%{1}%'or studentnumber like '%{1}%'or studentname like '%{1}%'or gender like '%{1}%'or birthday like '%{1}%'or mobile like '%{1}%'or deptname like '%{1}%'or email like '%{1}%'or logintimes like '%{1}%')",dept,keyword);
            }
            DataSet ds = new DataSet();
            SQLHelper sh = new SQLHelper();
            sh.RunSQL(sql, ref ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            sh.Close();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string sql = "delete from tblstudent where studentid = " + GridView1.DataKeys[e.RowIndex].Value.ToString();
            SQLHelper sh = new SQLHelper();
            sh.RunSQL(sql);
            sh.Close();
            search(ddldept.SelectedValue, tbxkeyword.Text);
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType==DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onMouseOver", "t=this.style.backgroundColor;this.style.backgroundColor='#c5d8fd'");
                e.Row.Attributes.Add("onMouseOut", "this.style.backgroundColor=t");
            }

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cbx = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (CheckBox2.Checked)
                {
                    cbx.Checked = true;
                }
                else
                {
                    cbx.Checked = false;
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteid = "";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cbx = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                if (cbx.Checked)
                {
                    deleteid += GridView1.DataKeys[GridView1.Rows[i].RowIndex].Value.ToString() + ",";
                }
            }
                if (deleteid.Contains(","))
                {
                    deleteid = deleteid.Substring(0, deleteid.Length - 1);
                    string sql = string.Format("delete from tblstudent where studentid in ({0})", deleteid);
                    SQLHelper sh = new SQLHelper();
                    sh.RunSQL(sql);
                    sh.Close();
                    search(ddldept.SelectedValue, tbxkeyword.Text);
                }

        }
    }
}