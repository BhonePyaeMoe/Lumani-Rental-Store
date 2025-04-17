using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumani_Rental_Store
{
    class Categorycls
    {
        string CategoryID, CategoryName;

        public string CID
        {
            get { return CategoryID; }
            set { CategoryID = value; }
        }
        public string CName
        {
            get { return CategoryName; }
            set { CategoryName = value; }
        }
    }
}
