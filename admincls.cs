using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumani_Rental_Store
{
    class admincls
    {
        string AdminID, AdminName, AdminUserName, AdminPassword, AdminPosition, AdminEmail, AdminPhoneNo, AdminNRC, AdminAddress;

        public string AID
        {
            get { return AdminID; }
            set { AdminID = value; }
        }
        public string AName
        {
            get { return AdminName; }
            set { AdminName = value; }
        }
        public string APassword
        {
            get { return AdminPassword; }
            set { AdminPassword = value; }
        }
        public string APosition
        {
            get { return AdminPosition; }
            set { AdminPosition = value; }
        }
        public string AUserName
        {
            get { return AdminUserName; }
            set { AdminUserName = value; }
        }
        public string AEmail
        {
            get { return AdminEmail; }
            set { AdminEmail = value; }
        }
        public string APhoneNo
        {
            get { return AdminPhoneNo; }
            set { AdminPhoneNo = value; }
        }
        public string ANRC
        {
            get { return AdminNRC; }
            set { AdminNRC = value; }
        }
        public string AAddress
        {
            get { return AdminAddress; }
            set { AdminAddress = value; }
        }
    }
}
