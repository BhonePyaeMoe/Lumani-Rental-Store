using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumani_Rental_Store
{
    class Appliancecls
    {
        string ApplianceID,ApplianceName,BrandID,CategoryID,PowerUsage,TypicalUsage,Energy,Description;

        int MonthlyFees, YearlyFees;     

        public string AID
        {
            get { return ApplianceID; }
            set { ApplianceID = value; }
        }
        public string AName
        {
            get { return ApplianceName; }
            set { ApplianceName = value; }
        }
        public string ABrand
        {
            get { return BrandID; }
            set { BrandID = value; }
        }
        public string ACategory
        {
            get { return CategoryID; }
            set { CategoryID = value; }
        }
        public int AMonthly
        {
            get { return MonthlyFees; }
            set { MonthlyFees = value; }
        }
        public string APower
        {
            get { return PowerUsage; }
            set { PowerUsage = value; }
        }
        public string ATypical
        {
            get { return TypicalUsage; }
            set { TypicalUsage = value; }
        }
        public int AYearly
        {
            get { return YearlyFees; }
            set { YearlyFees = value; }
        }
        public string AEnergy
        {
            get { return Energy; }
            set { Energy = value; }
        }
        public string ADescription
        {
            get { return Description; }
            set { Description = value; }
        }
    }
}
