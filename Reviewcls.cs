using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumani_Rental_Store
{
    class Reviewcls
    {
        string ReviewID, ApplianceID, CustomerID, ReviewDate, Feedback;
        int Rating;

        public string RID
        {
            get { return ReviewID; }
            set { ReviewID = value; }
        }
        public string AID
        {
            get { return ApplianceID; }
            set { ApplianceID = value; }
        }
        public string CID
        {
            get { return CustomerID; }
            set { CustomerID = value; }
        }
        public string RDate
        {
            get { return ReviewDate; }
            set { ReviewDate = value; }
        }
        public int Rate
        {
            get { return Rating; }
            set { Rating = value; }
        }
        public string Feed
        {
            get { return Feedback; }
            set { Feedback = value; }
        }


    }
}
