using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortugaMetlin4_ISP9_7.ClassHelper
{
    public class SaleClass
    {
        public static decimal countSale(int dayOfMonth, decimal Cost, string dayOfWeek)
        {
            try
            {
                if (dayOfWeek != "Monday" && dayOfWeek != "Tuesday" && dayOfWeek != "Wednesday" && dayOfWeek != "Thursday" && dayOfWeek != "Friday" && dayOfWeek != "Saturday" && dayOfWeek != "Sunday")
                {
                    return -1;
                }
                if (dayOfMonth > 31 || dayOfMonth < 1)
                {
                    return -1;
                }
                if (Cost < 0)
                {
                    return -1;
                }
                if ((dayOfMonth == 29 || dayOfMonth == 30 || dayOfMonth == 31) && dayOfWeek == "Saturday")
                {
                    return Cost * Convert.ToDecimal(0.89);
                }
                else
                {
                    return Cost;
                }
            }
            catch (Exception e)
            {
                return -1;
            }
            
            
        }
    }
}
