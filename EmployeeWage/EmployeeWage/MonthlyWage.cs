using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class MonthlyWage
    {
        private int totalDays;
        private double dailyWage;

        public MonthlyWage(double dailyWage,int totalDays )
        {
            this.totalDays = totalDays;
            this.dailyWage = dailyWage;
        }

        public double totalWage()
        {
            if(totalDays >= 20)
            {
                return totalDays * dailyWage;
            } else
            {
                return 0.0;
            }
            
        }
    }
}
                                                                                                                                                            