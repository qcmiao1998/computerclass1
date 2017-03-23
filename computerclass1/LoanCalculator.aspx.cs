using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace computerclass1
{
    public partial class LoanCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCal_Click(object sender, EventArgs e)
        {
            double totalloan = new double(); //借款总额
            double ratem = new double(); //月息
            double repaym = new double(); //月还款额
            //数据输入
            try
            {
                totalloan = double.Parse(tbxTotal.Text);
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('总金额输入有误！')</script>");
                return;
            }
            try
            {
                ratem = double.Parse(tbxRate.Text)/1200;
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('利率输入有误！')</script>");
                return;
            }
            try
            {
                repaym = double.Parse(tbxEM.Text);
            }
            catch
            {
                Response.Write("<script language='javascript'>alert('月供输入有误！')</script>");
                return;
            }
            //判断能否偿还
            if (repaym <= totalloan * ratem)
            {
                Response.Write("<script language='javascript'>alert('永远还不掉了啊！')</script>");
                return;
            }
            if (repaym >= totalloan + totalloan * ratem)
            {
                Response.Write("<script language='javascript'>alert('有这么多钱还贷款干嘛！')</script>");
                return;
            }
            int totalmonth = 0; //总偿还月数
            while (repaym < totalloan + totalloan * ratem)
            {
                totalloan = totalloan - (repaym - totalloan * ratem);
                totalmonth++;
            }
            LabelNumberofMonths.Text = (totalmonth + 1).ToString() + "&nbsp;月";
            LabelTotalBack.Text = (totalmonth * repaym + totalloan + totalloan * ratem).ToString("c");
            LabelTotalInterest.Text = (totalmonth * repaym + totalloan + totalloan * ratem - double.Parse(tbxTotal.Text)).ToString("c");
            LabelLastMonth.Text = (totalloan + totalloan * ratem).ToString("c");
        }
    }
}