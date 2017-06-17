using Dijkstra;
using SQL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FindRoad
{
    public partial class Route : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SQLHelper sh = new SQLHelper();
                DataSet ds = new DataSet();

                string sqlLocation = ("SELECT [Location1] AS [Location] FROM [dbo].[TblLocation] UNION SELECT [Location2] FROM [dbo].[TblLocation]");

                try
                {
                    sh.RunSQL(sqlLocation, ref ds);
                }
                catch (Exception ex)
                {
                    Response.Write(string.Format("<script> alert('{0}'); </script>", ex.Message.Replace("\r\n", "")));
                }
                finally
                {
                    sh.Close();
                    sh = null;
                }

                ddlStart.DataSource = ds.Tables[0];
                ddlEnd.DataSource = ds.Tables[0];

                ddlStart.DataTextField = "Location";
                ddlStart.DataValueField = "Location";

                ddlEnd.DataTextField = "Location";
                ddlEnd.DataValueField = "Location";

                ddlStart.DataBind();
                ddlEnd.DataBind();

                ddlStart.Items.Insert(0, new ListItem("Choose", "0"));
                ddlStart.SelectedValue = "0";

                ddlEnd.Items.Insert(0, new ListItem("Choose", "0"));
                ddlEnd.SelectedValue = "0";
            }

        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            if (ddlStart.SelectedValue == "0" || ddlEnd.SelectedValue == "0")
            {
                Response.Write("<script>alert('Didn't Choose!');</script>");
                return;
            }
            if (ddlStart.SelectedValue == ddlEnd.SelectedValue)
            {
                lblResult.Text = "There is no need to walk!";
                return;
            }

            SQLHelper sh = new SQLHelper();
            DataSet dsNodeList = new DataSet();

            string sqlNodeList = ("SELECT [Location1] AS [Location] FROM [dbo].[TblLocation] UNION SELECT [Location2] FROM [dbo].[TblLocation]");

            sh.RunSQL(sqlNodeList, ref dsNodeList);

            int nodeNumber = dsNodeList.Tables[0].Rows.Count;
            Node[] node = new Node[nodeNumber];
            ArrayList nodeList = new ArrayList();

            for (int i = 0; i < nodeNumber; i++)
            {
                node[i] = new Node(dsNodeList.Tables[0].Rows[i][0].ToString());
                nodeList.Add(node[i]);
            }

            DataSet dsPath = new DataSet();

            for (int i = 0; i < nodeNumber; i++)
            {
                string sqlNodePath = string.Format("SELECT [Location2] AS Location,[distance] FROM [dbo].[TblLocation] WHERE [Location1] = '{0}' UNION SELECT [Location1] AS Location,[distance] FROM [dbo].[TblLocation] WHERE [Location2] = '{0}' ", node[i].ID.ToString());

                sh.RunSQL(sqlNodePath, ref dsPath);

                for (int j = 0; j < dsPath.Tables[0].Rows.Count; j++)
                {
                    node[i].EdgeList.Add(new Edge(node[i].ID.ToString(), dsPath.Tables[0].Rows[j][0].ToString(), double.Parse(dsPath.Tables[0].Rows[j][1].ToString())));
                }

                dsPath = null;
            }

            sh.Close();
            sh = null;

            RoutePlanner planner = new RoutePlanner();
            RoutePlanResult result = planner.Paln(nodeList, ddlStart.SelectedValue, ddlEnd.SelectedValue);

            lblResult.Text = "Distance：" + result.getWeight().ToString() + "&nbsp;Route：" + DetailedRoute(result);

            planner = null;
        }

        private string DetailedRoute(RoutePlanResult result)
        {
            string[] point = result.getPassedNodeIDs();
            string route = "";

            for (int i = 0; i < point.Length; i++)
            {
                route += point[i] + "--->";
            }
            route += ddlEnd.SelectedValue;

            return route;
        }
    }
}