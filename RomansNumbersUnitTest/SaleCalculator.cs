using System;

namespace RomansNumbersUnitTest
{
    public class SaleCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            if (employee.Salary > 3000)
            {
                return employee.Salary * 0.8;
            }
            return employee.Salary * 0.9;
        }
    }
}