using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SQL;

namespace computerclass1
{
    public partial class dbtest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLHelper db = new SQLHelper();
            try
            {
                db.RunSelectSQLToScalar("select count(*) from tblstudent");
            }
            catch (Exception err)
            {
                Response.Write(string.Format("Error. {0}", err.Message));
                return;
            }
            Response.Write("success!");
            db.Close();
            db = null;
        }
    }
}