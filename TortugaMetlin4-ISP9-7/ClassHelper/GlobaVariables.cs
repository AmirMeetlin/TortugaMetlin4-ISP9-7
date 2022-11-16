using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TortugaMetlin4_ISP9_7.Windows;

namespace TortugaMetlin4_ISP9_7.ClassHelper
{
    internal class GlobaVariables
    {
        public static EF.IDTable selectedTable {get;set;}

        public class preOrder
        {
            public string title { get;set;}

            public int id { get;set;}

            public int qty { get;set;}

            public decimal price { get;set;}

            public decimal sum
            {
                get { return price * qty; }

            }
        }
        public static class ContainerOrder
        {
            public static List<preOrder> preOrderList = new List<preOrder>();
        }

        public static MenuWindow menuWindow {get;set;}

    }
}
