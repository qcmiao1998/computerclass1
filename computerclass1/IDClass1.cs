using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace computerclass1
{
    public class IDClass1
    {
        public int VerifyID(string ID)
        {
            //判断长度合法
            if (ID.Length != 18)
            {
                return 1;
            }
            //判断有无非数字或末尾X
            if (Regex.IsMatch(ID, @"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$") == false)
            {
                return 2;
            }


            return 0;
        }
    }
}