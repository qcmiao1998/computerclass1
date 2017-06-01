using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace computerclass1.admin
{
    public class BasePage : System.Web.UI.Page
    {
        public string studentnumber;
        public BasePage()
        {
            this.Load += new EventHandler(BasePage_Load);
        }
        void BasePage_Load(object sender, EventArgs e)
        {
            string browser = Request.UserAgent;
            if (browser == "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko")
            {
                Response.Write("<script>alert('Forbidden')</script>");
                Response.End();
                return;
            }
            if (Session["studentnumber"] == null)
            {
                Response.Redirect(string.Format("login.aspx?frompath={0}", Request.Path));
            }
            else
                studentnumber = Session["studentnumber"].ToString();
        }
    }
}