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
            if (dayOfWeek!= "Monday" || dayOfWeek != "Tuesday" || dayOfWeek != "Wednesday" || dayOfWeek != "Thursday" || dayOfWeek != "Friday" || dayOfWeek != "Saturday" || dayOfWeek != "Sunday")
            {

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
    }
}
