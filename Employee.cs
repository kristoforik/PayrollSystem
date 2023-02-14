using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    public class Employee
        
    {
        private string _firstName;
        private string _lastName;
        private long _sinNumber;

        public Employee(string firstName, string lastName, long sinNumber) 
        {
            _firstName= firstName;
            _lastName= lastName;
            _sinNumber= sinNumber;
        }
    }
}
