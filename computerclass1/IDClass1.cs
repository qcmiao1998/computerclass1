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
            //判断末尾校验
            int[] front17 = new int[17];
            int last1 = new int();
            if (ID.Substring(17,1)=="x" || ID.Substring(17, 1) == "X") //拆出末尾一位
            {
                last1 = 10;
            }
            else
            {
                int.TryParse(ID.Substring(17,1),out last1);
            }
            for (int i = 0; i < 17; i++) //前面17位
            {
                int.TryParse(ID.Substring(i, 1), out front17[i]);
            }
            int chknum = new int();
            chknum = front17[0] * 7 + front17[1] * 9 + front17[2] * 10 + front17[3] * 5 + front17[4] * 8 +
                front17[5] * 4 + front17[6] * 2 + front17[7] * 1 + front17[8] * 6 + front17[9] * 3 + front17[10] * 7 +
                front17[11] * 9 + front17[12] * 10 + front17[13] * 5 + front17[14] * 8 + front17[15] * 4 + front17[16] * 2;
            if (last1 != chknum % 11)
            {
                return 3;
            }

            return 0;
        }
    }
}