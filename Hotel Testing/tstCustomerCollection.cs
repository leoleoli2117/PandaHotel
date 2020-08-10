using System;
using System.Collections.Generic;
using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            Int32 SomeCount = 10;

            AllCustomer.Count = SomeCount;

            Assert.AreEqual(AllCustomer.Count, SomeCount);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();


            TestItem.CustomerName = "Leo";
            TestItem.CustomerEmail = "Li@Leo.com";
            TestItem.CustomerMobile = "07562159564";

            TestList.Add(TestItem);

            AllCustomer.CustomerList = TestList;

            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();


            TestItem.CustomerName = "Leo";
            TestItem.CustomerEmail = "Li@Leo.com";
            TestItem.CustomerMobile = "07562159564";

            TestList.Add(TestItem);

            AllCustomer.CustomerList = TestList;

            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {

            clsCustomerCollection AllCustoemr = new clsCustomerCollection();

            Assert.AreEqual(AllCustoemr.Count, 10);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            Int32 Primarykey = 0;

            clsCustomer TestItem = new clsCustomer();


            TestItem.CustomerName = "Leo";
            TestItem.CustomerEmail = "Li@gmail.com";
            TestItem.CustomerMobile = "01465879141";
            TestItem.Active = true;

            AllCustomer.ThisCustomer = TestItem;

            Primarykey = AllCustomer.Add();

            TestItem.CustomerId = Primarykey;

            AllCustomer.ThisCustomer.Find(Primarykey);

            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            Int32 PrimaryKey = 0;

            clsCustomer TestItem = new clsCustomer();


            TestItem.CustomerName = "Leo";
            TestItem.CustomerEmail = "Li@gmail.com";
            TestItem.CustomerMobile = "01465879141";
            TestItem.Active = true;

            AllCustomer.ThisCustomer = TestItem;

            PrimaryKey = AllCustomer.Add();

            TestItem.CustomerId = PrimaryKey;

            AllCustomer.ThisCustomer.Find(PrimaryKey);

            AllCustomer.Delete();

            Boolean Found = AllCustomer.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.CustomerName = "Leo";
            TestItem.CustomerEmail = "Li@gmail.com";
            TestItem.CustomerMobile = "01465879141";

            AllCustomer.ThisCustomer = TestItem;

            PrimaryKey = AllCustomer.Add();

            TestItem.CustomerId = PrimaryKey;

            TestItem.Active = false;
            TestItem.CustomerName = "Janet";
            TestItem.CustomerEmail = "Janet@hotmail.com";
            TestItem.CustomerMobile = "02449879796";

            AllCustomer.ThisCustomer = TestItem;

            AllCustomer.Update();

            AllCustomer.ThisCustomer.Find(PrimaryKey);

            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void ReportByCustomerNameMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();

            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();

            FilteredCustomer.ReportByCustomerName("");

            Assert.AreEqual(AllCustomer.Count, FilteredCustomer.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameNoneFound()
        {
            clsCustomerCollection FiltededCustomer = new clsCustomerCollection();

            FiltededCustomer.ReportByCustomerName("xxx xxx");

            Assert.AreEqual(0, FiltededCustomer.Count);
        }

        [TestMethod]
        public void ReportByCustomerNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomer = new clsCustomerCollection();

            Boolean OK = true;

            FilteredCustomer.ReportByCustomerName("yyy yyy");

            if (FilteredCustomer.Count == 2)
            {

                if (FilteredCustomer.CustomerList[0].CustomerId != 2)
                {
                    OK = false;
                }

                if (FilteredCustomer.CustomerList[1].CustomerId != 6)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }

                Assert.IsTrue(OK);
            }
        }
    }
}
