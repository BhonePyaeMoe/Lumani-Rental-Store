using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumani_Rental_Store
{
    class Customercls
    {
        string CustomerID, CustomerName, Username, CustomerPassword, Gender, PhoneNumber, Email, Address;

        public string CID
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }
        public string CName
        {
            get { return CustomerName; }
            set { CustomerName = value; }
        }
        public string CUserName
        {
            get { return Username; }
            set { Username = value; }
        }
        public string CPassword
        {
            get { return CustomerPassword; }
            set { CustomerPassword = value; }
        }
        public string CGender
        {
            get { return Gender; }
            set { Gender = value; }
        }
        public string CPhoneNo
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }
        public string CEmail
        {
            get { return Email; }
            set { Email = value; }
        }
        public string CAddress
        {
            get { return Address; }
            set { Address = value; }
        }

    }
}
