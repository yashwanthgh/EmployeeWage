using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Welcome
    {
        public static void greetings()
        {
            Console.WriteLine("Hello, Welcome to Employee Wage Computation");
            Console.WriteLine("Calculate the daily and monthly wage of an Employee");
            Console.WriteLine("To calculate daily wage Press 1");
            Console.WriteLine("To calculate Monthly salary of Full time employee Press 2");
            Console.WriteLine("To calculate salary of Part time employee Press 3");

            int choice = Convert.ToInt32(Console.ReadLine());
            double dailyPay = 160;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter hourly Pay and Hours employee worked");
                    int hours = Convert.ToInt32(Console.ReadLine());
                    int hourlyPay = Convert.ToInt32(Console.ReadLine());
                    DailyWage dailyWage = new DailyWage(hourlyPay, hours);
                    double amount = dailyWage.dailyWage();
                    Console.WriteLine($"{amount} is employees daily pay");
                    dailyPay = amount;
                    break;

                case 2:
                    Console.WriteLine("Enter number of days Employee worked: ");
                    int days = Convert.ToInt32(Console.ReadLine());
                    MonthlyWage monthlyWage = new MonthlyWage(dailyPay, days);
                    double totalSalary = monthlyWage.totalWage();
                    Console.WriteLine($"{totalSalary} is employees monthly salary");
                    break; 
                case 3:
                    Console.WriteLine("Enter number of days and hourly pay of the employee");
                    int partTimedays = Convert.ToInt32(Console.ReadLine());
                    double salary = Convert.ToInt32(Console.ReadLine());
                    PartTimeEmployee partTimeEmployee = new PartTimeEmployee(salary, partTimedays);
                    double partTimeSalary = partTimeEmployee.dailyWage();
                    Console.WriteLine(partTimeSalary);
                    break; 
            }

        }
        static void Main(string[] args)
        {
            greetings();
        }
    }
}
