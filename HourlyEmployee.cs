using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class HourlyEmployee : Employee
    {
        private double _hourlyRate;
        private int _hoursWorked;
        public HourlyEmployee(string firstName, string lastName, long sinNumber, double hourlyRate, int hoursWorked) : base(firstName, lastName, sinNumber)
        {
            _hourlyRate = hourlyRate;
            _hoursWorked = hoursWorked;
        }
        public double CalculateSalary()
        {
            double regularPay = 0;
            double overtimePay = 0;
            if (_hoursWorked > 40)
            {
                regularPay = 40 * _hourlyRate;
                overtimePay = (_hoursWorked - 40) * (_hourlyRate * 1.5);
            }
            else
            {
                regularPay = _hoursWorked * _hourlyRate;
            }
            double totalPay = regularPay + overtimePay;
            return totalPay;
        }
    }
}
