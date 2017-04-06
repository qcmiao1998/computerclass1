using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace computerclass1.admin
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            servername.Text = Environment.MachineName;
            serverport.Text = Request.Url.Port.ToString();
            serverengine.Text = Environment.Version.ToString();
            root.Text = Request.PhysicalApplicationPath.ToString();
            cpunum.Text = Environment.ProcessorCount.ToString();
            iisver.Text = Request.ServerVariables["SERVER_SOFTWARE"];
            totaltime.Text = (Environment.TickCount / 3600000).ToString();
            servertime.Text = DateTime.Now.ToString();
            serveros.Text = Environment.OSVersion.ToString();
            browser.Text = Request.Browser.Version.ToString();
            
        }
    }
}