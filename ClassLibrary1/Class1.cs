using System;

namespace ClassLibrary1
{
    public class SalaryCalculator
    {
        private double _numberOfDaysWorkPerWeek;
        private double _ratePerDay;
        private double _taxRate;
        private double _sss;
        private double _medicare;
        private double _grossPay;
        private double _deduction;
        private double _netPay;

        // Properties to access and set private variables

        public double NumberOfDaysWorkPerWeek
        {
            get { return _numberOfDaysWorkPerWeek; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of days worked per week cannot be negative.");
                }
                _numberOfDaysWorkPerWeek = value;
            }
        }

        public double RatePerDay
        {
            get { return _ratePerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rate per day cannot be negative.");
                }
                _ratePerDay = value;
            }
        }

        public double TaxRate
        {
            get { return _taxRate; }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Tax rate must be between 0 and 1.");
                }
                _taxRate = value;
            }
        }

        public double SSS
        {
            get { return _sss; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("SSS deduction cannot be negative.");
                }
                _sss = value;
            }
        }

        public double Medicare
        {
            get { return _medicare; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Medicare deduction cannot be negative.");
                }
                _medicare = value;
            }
        }

        // Method to calculate Gross Pay
        public double CalculateGrossPay()
        {
            _grossPay = _numberOfDaysWorkPerWeek * _ratePerDay;
            return _grossPay;
        }

        // Method to calculate Tax
        public double CalculateTax()
        {
            _deduction += _grossPay * _taxRate;
            return _deduction;
        }

        // Method to calculate Deduction
        public double CalculateDeduction()
        {
            _deduction += _sss + _medicare;
            return _deduction;
        }

        // Method to calculate Net Pay
        public double CalculateNetPay()
        {
            _netPay = _grossPay - _deduction;
            return _netPay;
        }
    }
}
