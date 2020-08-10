using System;
using System.Collections.Generic;

namespace HotelClasses
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        clsCustomer mThisCustomer = new clsCustomer();

        public int Count
        {
            get
            {

                return mCustomerList.Count;
            }
            set
            {

            }
        }

        public List<clsCustomer> CustomerList
        {
            get
            {

                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }



        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }



        public clsCustomerCollection()
        {
            clsDataConnection db = new clsDataConnection();

            db.Execute("sproc_tblCustomer_SelectAll");

            PopulateArray(db);
        }

        void PopulateArray(clsDataConnection db)
        {
            mCustomerList = new List<clsCustomer>();
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = db.Count;



            while (Index < RecordCount)
            {
                clsCustomer TestItem = new clsCustomer();

                TestItem.CustomerId = Convert.ToInt32(db.DataTable.Rows[Index]["CustomerId"]);
                TestItem.CustomerName = Convert.ToString(db.DataTable.Rows[Index]["CustomerName"]);
                TestItem.CustomerEmail = Convert.ToString(db.DataTable.Rows[Index]["Email"]);
                TestItem.Active = Convert.ToBoolean(db.DataTable.Rows[Index]["Active"]);
                TestItem.CustomerMobile = Convert.ToString(db.DataTable.Rows[Index]["Phone"]);
                mCustomerList.Add(TestItem);
                Index++;
            }
        }

        public int Add()
        {

            clsDataConnection db = new clsDataConnection();


            db.AddParameter("CustomerName", mThisCustomer.CustomerName);
            db.AddParameter("Email", mThisCustomer.CustomerEmail);
            db.AddParameter("Phone", mThisCustomer.CustomerMobile);
            db.AddParameter("Active", mThisCustomer.Active);

            return db.Execute("sproc_tblCustomer_Insert");

        }



        public void Delete()
        {

            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@CustomerId", mThisCustomer.CustomerId);

            db.Execute("sproc_tblCustomer_Delete");
        }

        public void Update()
        {

            clsDataConnection db = new clsDataConnection();

            db.AddParameter("CustomerId", mThisCustomer.CustomerId);
            db.AddParameter("CustomerName", mThisCustomer.CustomerName);
            db.AddParameter("Email", mThisCustomer.CustomerEmail);
            db.AddParameter("Phone", mThisCustomer.CustomerMobile);
            db.AddParameter("Active", mThisCustomer.Active);

            db.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@CustomerName", CustomerName);

            db.Execute("sproc_tblCustomer_FilterByCustomerName");

            PopulateArray(db);
        }
    }
}