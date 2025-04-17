using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumani_Rental_Store
{
    class brandcls
    {
        string BrandID, BrandName, BrandModel,BrandColor;

        public string BID
        {
            get { return BrandID; }
            set { BrandID = value; }
        }
        public string BName
        {
            get { return BrandName; }
            set { BrandName = value; }
        }
        public string BModel
        {
            get { return BrandModel; }
            set { BrandModel = value; }
        }
        public string BColor
        {
            get { return BrandColor; }
            set { BrandColor = value; }
        }
    }
}

