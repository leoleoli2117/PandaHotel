using System;

namespace HotelClasses
{
    public class clsOrder
    {
        private int mOrderId;
        public int OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
        private string mOrderNo;
        public string OrderNo
        {
            get
            {
                return mOrderNo;
            }
            set
            {
                mOrderNo = value;
            }
        }
        private DateTime mOrderDate;
        public DateTime OrderDate
        {
            get
            {
                return mOrderDate;
            }
            set
            {
                mOrderDate = value;
            }
        }
        private bool mStatus;
        public bool Status
        {
            get
            {
                return mStatus;
            }
            set
            {
                mStatus = value;
            }
        }

        public bool Find(int orderId)
        {

            mOrderId = 2;

            return true;

        }

        public string Valid(string mOrderNo, DateTime mOrderDate, bool mStatus)
        {
            String Error = "";
            if (mOrderNo.Length == 0)
            {
                Error = Error + "The order number may not be blank.";
            }
            if (mOrderNo.Length > 20)
            {
                Error = Error + "The order number must be less than 20 characters.";
            }
            return Error;
        }
    }
}