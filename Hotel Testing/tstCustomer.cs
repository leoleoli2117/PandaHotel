using System;
using HotelClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hotel_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Int32 TestData = 1000;

            ACustomer.CustomerId = TestData;

            Assert.AreEqual(ACustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "Leo";

            ACustomer.CustomerName = TestData;

            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }



        [TestMethod]
        public void CustomerPhonePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "07562159564";

            ACustomer.CustomerMobile = TestData;

            Assert.AreEqual(ACustomer.CustomerMobile, TestData);
        }

        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "Li@Leo.com";

            ACustomer.CustomerEmail = TestData;

            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean TestData = true;

            ACustomer.Active = TestData;

            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Int32 CustomerId = 1;

            Found = ACustomer.Find(CustomerId);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;

            Boolean OK = true;

            Int32 CustomerId = 2;

            Found = ACustomer.Find(CustomerId);

            if (ACustomer.CustomerId != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        string tCustomerName = "Leo Li";
        string tCustomerMobile = "07562159564";
        string tCustomerEmail = "Li@Leo.com";
        bool tActive = true;

        [TestMethod]
        public void ValidMethodOk()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(tCustomerName, tCustomerMobile, tCustomerEmail, tActive);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {

            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            Error = ACustomer.Valid(CustomerName, tCustomerMobile, tCustomerEmail, tActive);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "a";
            Error = ACustomer.Valid(CustomerName, tCustomerMobile, tCustomerEmail, tActive);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "aa";
            Error = ACustomer.Valid(CustomerName, tCustomerMobile, tCustomerEmail, tActive);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerName = "ccccccccccccccccccc";

            Error = ACustomer.Valid(CustomerName, tCustomerMobile, tCustomerEmail, tActive);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerName = "eeeeeeeeee";

            Error = ACustomer.Valid(CustomerName, tCustomerMobile, tCustomerEmail, tActive);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerName = "ffffffffffffffffffffff";

            Error = ACustomer.Valid(CustomerName, tCustomerMobile, tCustomerEmail, tActive);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerName = "";

            CustomerName = CustomerName.PadRight(500, 'a');

            Error = ACustomer.Valid(CustomerName, tCustomerMobile, tCustomerEmail, tActive);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerMobileMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerMobile = "";

            Error = ACustomer.Valid(tCustomerName, CustomerMobile, tCustomerEmail, tActive);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerMobileMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerMobile = "+888888888888888";

            Error = ACustomer.Valid(tCustomerName, CustomerMobile, tCustomerEmail, tActive);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerMobileMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerMobile = "+8888888888888887";

            Error = ACustomer.Valid(tCustomerName, CustomerMobile, tCustomerEmail, tActive);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailAtSignTest()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";

            string CustomerEmail = "Leoli.com";

            Error = ACustomer.Valid(tCustomerName, tCustomerMobile, CustomerEmail, tActive);

            Assert.AreNotEqual(Error, "");
        }
    }
}
