using SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bayes
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGuess_Click(object sender, EventArgs e)
        {
            SQLHelper sh = new SQLHelper();
            DataSet ds = new DataSet();

            //SQL输出语句
            string sql = @"
            SELECT [Sex],[Height],[Weight],[Foot]
            FROM [dbo].[TblBayesV1]
            ";

            //执行SQL
            try
            {
                sh.RunSQL(sql, ref ds);
            }
            catch (Exception ex)
            {
                this.Response.Write(string.Format(@"
                    <script>
                        alert('{0}');
                    </script>
                ", ex.Message.Replace("\r\n", "")));
            }

            //创建测试表
            DataTable dt = new DataTable();
            dt.Columns.Add("Sex");
            dt.Columns.Add("Height", typeof(double));
            dt.Columns.Add("Weight", typeof(double));
            dt.Columns.Add("Foot", typeof(double));

            //for test
            /*
            datatable.Rows.Add("1", 183, 81.5, 30.5);
            datatable.Rows.Add("1", 180.5, 86, 28);
            datatable.Rows.Add("1", 170, 77, 30.5);
            datatable.Rows.Add("1", 180.5, 75, 25.5);

            datatable.Rows.Add("0", 152.5, 45, 15);
            datatable.Rows.Add("0", 168, 68, 20);
            datatable.Rows.Add("0", 165, 59, 18);
            datatable.Rows.Add("0", 175, 68, 23);
             * */

            //数据库注入测试表
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt.Rows.Add(ds.Tables[0].Rows[i][0].ToString(), double.Parse(ds.Tables[0].Rows[i][1].ToString()), double.Parse(ds.Tables[0].Rows[i][2].ToString()), double.Parse(ds.Tables[0].Rows[i][3].ToString()));
            }

            //测试表分析
            Classifier classifier = new Classifier();
            classifier.TrainClassifier(dt);

            double height, weight, foot;

            //转换格式 防报错
            try
            {
                height = double.Parse(txtHeight.Text);
                weight = double.Parse(txtWeight.Text);
                foot = double.Parse(txtFoot.Text);
            }
            catch (Exception ex)
            {
                this.Response.Write(string.Format(@"
                    <script>
                        alert('{0}');
                    </script>
                ", ex.Message.Replace("\r\n", "")));

                return;
            }

            //正式数据分析
            string classifyresult = classifier.Classify(new double[] { height, weight, foot });

            //输出结果
            lblResult.Text = classifyresult == "1" ? "Male" : "Female";
        }
    }
}