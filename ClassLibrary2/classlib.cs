using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class SalaryCalculator
    {

        public double CalculateGrossPay(double numberOfDaysWorkPerWeek, double ratePerDay)
        {
            return numberOfDaysWorkPerWeek * ratePerDay;
        }

        public double CalculateTax(double grossPay, double taxRate)
        {
            return grossPay * taxRate;
        }

        public double CalculateDeduction(double sss, double medicare, double tax)
        {
            return sss + medicare + tax;
        }

        public double CalculateNetPay(double grossPay, double deduction)
        {
            return grossPay - deduction;
        }
    }
}
