using System;
using System.Collections.Generic;
using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Testing
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();

            Int32 SomeCount = 10;

            AllOrder.Count = SomeCount;

            Assert.AreEqual(AllOrder.Count, SomeCount);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.OrderNo = "ON001";
            TestItem.OrderDate = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllOrder.OrderList = TestList;

            Assert.AreEqual(AllOrder.OrderList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();

            List<clsOrder> TestList = new List<clsOrder>();

            clsOrder TestItem = new clsOrder();

            TestItem.OrderNo = "ON001";
            TestItem.OrderDate = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllOrder.OrderList = TestList;
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();

            Assert.AreEqual(AllOrder.Count, 10);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.Status = true;
            TestItem.OrderId = 10;
            TestItem.OrderNo = "ON001";
            TestItem.OrderDate = DateTime.Now.Date;

            AllOrder.ThisOrder = TestItem;

            PrimaryKey = AllOrder.Add();

            TestItem.OrderId = PrimaryKey;

            AllOrder.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrder = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.Status = true;
            TestItem.OrderId = 10;
            TestItem.OrderNo = "ON001";
            TestItem.OrderDate = DateTime.Now.Date;

            AllOrder.ThisOrder = TestItem;

            PrimaryKey = AllOrder.Add();

            TestItem.OrderId = PrimaryKey;

            AllOrder.ThisOrder.Find(PrimaryKey);

            AllOrder.Delete();

            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
    }
}
