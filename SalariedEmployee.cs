using System;
using Android.Accounts;
using static AndroidX.ConstraintLayout.Core.Motion.Utils.HyperSpline;

namespace PayrollSystem
{
	public class SalariedEmployee: Employee 
	{
		private double _amount;

		public SalariedEmployee(string firstName, string lastName, long sinNumber, double amount) : base(firstName, lastName, sinNumber)
		{
			_amount = amount;
		}

		public double CalculateSalary(double amount)
		{
			return amount;
		}
          
	}
}

