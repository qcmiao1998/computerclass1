using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace computerclass1
{
    public partial class if1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] intA = new int[10];
            Random rand = new Random();
            for (int i=0; i<=9; i++)
            {
                intA[i] = rand.Next(1, 100);
            }
            int maxA = new int();
            for (int ii=0; ii<=9; ii++)
            {
                if (intA[ii] > maxA)
                {
                    maxA = intA[ii];
                }
                
             }
            Response.Write(maxA);


        }
    }
}