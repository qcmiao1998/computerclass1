using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Data;


namespace computerclass1
{
    public class IDClass1
    {
        public int VerifyID(string ID) //检查有无错误
        {
            //判断长度合法，错误返回1
            if (ID.Length != 18)
            {
                return 1;
            }
            //判断有无非数字或末尾X，错误返回2
            if (Regex.IsMatch(ID, @"^[1-9]\d{5}(18|19|([23]\d))\d{2}((0[1-9])|(10|11|12))(([0-2][1-9])|10|20|30|31)\d{3}[0-9Xx]$") == false)
            {
                return 2;
            }
            //判断末尾校验，错误返回3
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
            chknum = chknum % 11;
            if (chknum != 0 && chknum != 1 && last1 + chknum != 12)
            {
                return 3;
            }
            else if (chknum == 1 && last1 != 0)
            {
                return 3;
            }
            else if (chknum == 0 && last1 != 1)
            {
                return 3;
            }

            return 0;
        }

        public void GetIDinfo (string ID, out string hometown, out DateTime birthday, out bool gender)
        {
            string frompart, birthpart, genderpart;
            frompart = ID.Substring(0, 6);
            birthpart = ID.Substring(6, 8);
            genderpart = ID.Substring(16, 1);

            //获取出生地
            try 
	        {	        
		        Entities1 db = new Entities1();
                var province = (from c in db.cityID where c.Id == frompart.Substring(0,2)+ "0000" select c.city).Single();
                var city = (from c in db.cityID where c.Id == frompart.Substring(0, 4) + "00" select c.city).Single();
                var town = (from c in db.cityID where c.Id == frompart select c.city).Single();
                //string prov, cit;
                //foreach (var item in province)
                //{
                //    prov = item;
                //}
                //foreach (var item in city)
                //{
                //    cit = item;
                //}
                hometown = province + city + town;
	        }
	        catch (Exception a)
	        {
                hometown = "Err. " + a;
		        
	        }
           
            //获取生日
            birthday = DateTime.ParseExact(birthpart, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            //获取性别
            if (int.Parse(genderpart)%2==1)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            
        }
    }
}