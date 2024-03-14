using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class PartTimeEmployee
    {
        private double wagePerHour;
        private int workingHours;

        public PartTimeEmployee(double wagePerHour, int workingHours)
        {
            this.wagePerHour = wagePerHour;
            this.workingHours = workingHours;
        }

        public double dailyWage()
        {
            return workingHours * wagePerHour;
        }
    }
}
