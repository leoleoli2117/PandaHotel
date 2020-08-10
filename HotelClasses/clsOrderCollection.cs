using System;
using System.Collections.Generic;

namespace HotelClasses
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();

        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            clsDataConnection db = new clsDataConnection();

            db.Execute("sproc_tblOrder_SelectAll");

            PopulateArray(db);
        }

        void PopulateArray(clsDataConnection db)
        {
            mOrderList = new List<clsOrder>();

            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = db.Count;



            while (Index < RecordCount)
            {
                clsOrder TestItem = new clsOrder();

                TestItem.OrderId = Convert.ToInt32(db.DataTable.Rows[Index]["OrderId"]);
                TestItem.OrderNo = Convert.ToString(db.DataTable.Rows[Index]["OrderNo"]);
                TestItem.OrderDate = Convert.ToDateTime(db.DataTable.Rows[Index]["OrderDate"]);
                TestItem.Status = Convert.ToBoolean(db.DataTable.Rows[Index]["Status"]);
                mOrderList.Add(TestItem);
                Index++;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("OrderNo", mThisOrder.OrderNo);
            db.AddParameter("OrderDate", mThisOrder.OrderDate);
            db.AddParameter("Status", mThisOrder.Status);

            return db.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@OrderId", mThisOrder.OrderId);

            db.Execute("sproc_tblOrder_Delete");
        }
    }
}