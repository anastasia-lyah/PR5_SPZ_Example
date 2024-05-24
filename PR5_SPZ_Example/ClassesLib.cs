using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5_SPZ_Example
{
    public class Town
    {
        public string Name; 
        public string Country; 
        public string Region;
        public int Population; 
        public double YearIncome; 
        public double Square; 
        public bool HasPort;
        public bool HasAirport;
        public double yearIncomePerInhabitant
        {
            get
            {
                return GetYearIncomePerInhabitant();
            }
        }
        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Population;
        }
    }
}
