using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TortugaMetlin4_ISP9_7.ClassHelper;
using static TortugaMetlin4_ISP9_7.ClassHelper.SaleClass;

namespace TortugaMetlin4_ISP9_7_Tests
{
    [TestClass]
    public class countSale_Tests
    {
        [TestMethod]
        public void countSale_CostWithPromocode_ReturnTrue()
        {
            //AVERAGE
            int dayOfMonth =29;
            decimal Cost=1000;
            string dayOfWeek="Saturday";
            decimal ex=890;
            //ACT
            decimal fct = SaleClass.countSale(dayOfMonth,Cost,dayOfWeek);
            //ASSERT
            Assert.AreEqual(ex,fct);
        }

        [TestMethod]
        public void countSale_OrderWithIncorrectDayOfMonth_ReturnTrue()
        {
            //AVERAGE
            int dayOfMonth = 20;
            decimal Cost = 1000;
            string dayOfWeek = "Saturday";
            decimal ex = 1000;
            //ACT
            decimal fct = SaleClass.countSale(dayOfMonth, Cost, dayOfWeek);
            //ASSERT
            Assert.AreEqual(ex, fct);
        }

        [TestMethod]
        public void countSale_OrderWithIncorrectDayOfWeek_ReturnTrue()
        {
            //AVERAGE
            int dayOfMonth = 29;
            decimal Cost = 1000;
            string dayOfWeek = "Sunday";
            decimal ex = 1000;
            //ACT
            decimal fct = SaleClass.countSale(dayOfMonth, Cost, dayOfWeek);
            //ASSERT
            Assert.AreEqual(ex, fct);
        }

        [TestMethod]
        public void countSale_OrderWithIncorrectDayOfWeek_ReturnTrue()
        {
            //AVERAGE
            int dayOfMonth = 29;
            decimal Cost = 1000;
            string dayOfWeek = "Sunday";
            decimal ex = 1000;
            //ACT
            decimal fct = SaleClass.countSale(dayOfMonth, Cost, dayOfWeek);
            //ASSERT
            Assert.AreEqual(ex, fct);
        }
    }
}
