using System;
using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AOrder = new clsOrder();

            Assert.IsNotNull(AOrder);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {

            clsOrder AOrder = new clsOrder();

            Int32 TestData = 100;

            AOrder.OrderId = TestData;

            Assert.AreEqual(AOrder.OrderId, TestData);
        }

        [TestMethod]
        public void OrderNoPropertOK()
        {
            clsOrder AOrder = new clsOrder();

            String TestData = "ON001";

            AOrder.OrderNo = TestData;

            Assert.AreEqual(AOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void OrderDatePropertOK()
        {
            clsOrder AOrder = new clsOrder();

            DateTime TestData = DateTime.Now.Date;

            AOrder.OrderDate = TestData;

            Assert.AreEqual(AOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer AOrder = new clsCustomer();

            Int32 TestData = 100;

            AOrder.CustomerId = TestData;

            Assert.AreEqual(AOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            clsOrder AOrder = new clsOrder();

            Boolean TestData = false;

            AOrder.Status = TestData;

            Assert.AreEqual(AOrder.Status, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AOrder = new clsOrder();

            Boolean Found = false;

            Int32 OrderId = 1;

            Found = AOrder.Find(OrderId);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdNoFound()
        {
            clsOrder AOrder = new clsOrder();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderId = 2;

            Found = AOrder.Find(OrderId);

            if (AOrder.OrderId != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        string mOrderNo = "ON001";
        DateTime mOrderDate = DateTime.Now.Date;
        bool mStatus = true;

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            Error = AOrder.Valid(mOrderNo, mOrderDate, mStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNOMinLessOne()
        {

            clsOrder AOrder = new clsOrder();
            String Error = "";
            string OrderNo = "";
            Error = AOrder.Valid(OrderNo, mOrderDate, mStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNONoMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            string OrderNo = "a";
            Error = AOrder.Valid(OrderNo, mOrderDate, mStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNONoMinPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            string OrderNo = "aa";
            Error = AOrder.Valid(OrderNo, mOrderDate, mStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNOMaxLessOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            string OrderNo = "ccccccccccccccccccc";
            Error = AOrder.Valid(OrderNo, mOrderDate, mStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNOMid()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            string OrderNO = "eeeeeeeeee"; //10 characters
            Error = AOrder.Valid(OrderNO, mOrderDate, mStatus);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNOMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            string OrderNO = "ffffffffffffffffffffff"; //21 characters
            Error = AOrder.Valid(OrderNO, mOrderDate, mStatus);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNOExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            string OrderNO = "";
            OrderNO = OrderNO.PadRight(500, 'a');  //21 characters
            Error = AOrder.Valid(OrderNO, mOrderDate, mStatus);
            Assert.AreNotEqual(Error, "");
        }
    }
}
