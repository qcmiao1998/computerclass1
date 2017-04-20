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

        protected void btnadd_Click(object sender, EventArgs e)
        {
            SQLHelper db = new SQLHelper();
            string username = tbxusername.Text;
            string pwd = tbxpwd.Text;
            string sql = string.Format("insert into admin (username,pwd)values('{0}','{1}')", username, pwd);
            if (db.RunSQL(sql)>0)
            {
                Response.Write("<script language='javascript'>alert ('success')</script>");
            }
            else
            {
                Response.Write("<script language='javascript'>alert ('fail')</script>");
            }
            db.Close();
        }
    }
}