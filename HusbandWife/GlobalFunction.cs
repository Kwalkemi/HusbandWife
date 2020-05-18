using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusbandWife
{
    public static class GlobalFunction
    {
        public static DateTime GetFirstDateOfMonth(this int aintYear, int aintMonth)
        {
            DateTime ldtDate = new DateTime(aintYear, aintMonth, 1);
            return ldtDate;
        }

        public static DateTime GetLastDateOfMonth(this int aintYear, int aintMonth)
        {
            DateTime ldtDate = new DateTime(aintYear, aintMonth, 1);
            ldtDate = ldtDate.AddMonths(1).AddDays(-1);
            return ldtDate;
        }

        public static List<string> GetMonthNameFromQuarter(this int aQuarter)
        {
            List<string> lstMonth = new List<string>();

            switch (aQuarter)
            {
                case 0:
                    {
                        lstMonth.Add("January");
                        lstMonth.Add("Febuary");
                        lstMonth.Add("March");
                        break;
                    }
                case 1:
                    {
                        lstMonth.Add("April");
                        lstMonth.Add("May");
                        lstMonth.Add("June");
                        break;
                    }
                case 2:
                    {
                        lstMonth.Add("July");
                        lstMonth.Add("August");
                        lstMonth.Add("September");
                        break;
                    }
                case 3:
                    {
                        lstMonth.Add("October");
                        lstMonth.Add("November");
                        lstMonth.Add("December");
                        break;
                    }
            }
            return lstMonth;
        }

        /// <summary>
        /// Get the ceiling number
        /// </summary>
        /// <param name="aintnum"></param>
        /// <param name="withRef">with reference of</param>
        /// <returns></returns>
        public static int GetCeilingNumber(this int aintnum, int withRef)
        {
            int num = (aintnum / 1000) + 1;
            num = num * 1000;
            return num;
        }
    }
}
