using System;

namespace HotelClasses
{
    public class clsCustomer
    {
        private Int32 tCustomerId;
        private string tCustomerName;
        private string tCustomerMobile;
        private string tCustomerEmail;
        private bool tActive;

        public clsCustomer()
        {
        }

        public int CustomerId
        {
            get
            {
                return tCustomerId;
            }
            set
            {
                tCustomerId = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return tCustomerName;
            }
            set
            {
                tCustomerName = value;
            }
        }

        public string CustomerMobile
        {
            get
            {
                return tCustomerMobile;
            }
            set
            {
                tCustomerMobile = value;
            }
        }
        public string CustomerEmail
        {
            get
            {
                return tCustomerEmail;
            }
            set
            {
                tCustomerEmail = value;
            }
        }
        public bool Active
        {
            get
            {
                return tActive;
            }
            set
            {
                tActive = value;
            }
        }

        public bool Find(int CustomerId)
        {
            tCustomerId = 2;

            return true;
        }

        public string Valid(string tCustomerName, string tCustomerMobile, string tCustomerEmail, bool tActive)
        {
            String Error = "";
            if (tCustomerName.Length == 0)
            {
                Error = Error + "The customer name may not be blank.";
            }
            if (tCustomerName.Length > 20)
            {
                Error = Error + "The customer name must be less than 20 characters.";
            }
            if (tCustomerMobile.Length == 0)
            {
                Error = Error + "The customermobile maynot be blank.";
            }
            if (tCustomerMobile.Length > 16)
            {
                Error = Error + "The customer mobile can not be less than characters.";
            }
            if (!tCustomerEmail.Contains("@"))
            {
                Error = Error + "The customer email is not in the right format";
            }
            return Error;
        }
    }
}