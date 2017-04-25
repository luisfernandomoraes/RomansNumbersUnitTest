using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomansNumbersUnitTest.UnitTest
{
    [TestClass]
    public class CalculadoraDeSalarioTest
    {
        [TestMethod]
        public void DeveCalcularSalarioDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            // Arrange
            var calculator = new SaleCalculator();
            var developer = new Employee(name:"Luís", salary: 1500.0, responsibility: Responsibility.Developer);

            // Act
            var salary = calculator.CalculateSalary(developer);

            // Assert
            Assert.AreEqual(developer.Salary * 0.9,salary,0.0001);
        }

        [TestMethod]
        public void DeveCalcularSalarioDesenvolvedoresComSalarioAcimaDoLimite()
        {
            // Arrange
            var calculator = new SaleCalculator();
            var developer = new Employee(name: "Mauricio", salary: 4000.0, responsibility: Responsibility.Developer);

            // Act
            var salary = calculator.CalculateSalary(developer);

            // Assert
            Assert.AreEqual(developer.Salary * 0.8, salary, 0.0001);
        }

        [TestMethod]
        public void DeveCalcularSalarioParaDBAComSalarioAbaixoDoLimite()
        {
            // Arrange
            var calculator = new SaleCalculator();
            var dba = new Employee(name: "Mauricio", salary: 500.0, responsibility: Responsibility.DBA);

            // Act
            var salary = calculator.CalculateSalary(dba);

            // Assert
            Assert.AreEqual(dba.Salary * 0.85, salary, 0.0001);
        }


    }
}
