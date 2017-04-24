using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomansNumbersUnitTest.UnitTest
{
    [TestClass]
    public class RomanNumberConvertTest
    {
        [TestMethod]
        public void Should_Understand_the_I_Simbol()
        {
            // Arrange
            var romanNumberConvert = new RomanNumberConvert();

            // Act
            int number = romanNumberConvert.Convert("I");

            // Assert
            Assert.AreEqual(1,number);

        }

        [TestMethod]
        public void Should_Understand_the_V_Simbol()
        {
            // Arrange
            var romanNumberConvert = new RomanNumberConvert();

            // Act
            int number = romanNumberConvert.Convert("V");

            // Assert
            Assert.AreEqual(5, number);

        }


        [TestMethod]
        public void Should_Understand_Simbols_Like_II_()
        {
            // Arrange
            var romanNumberConvert = new RomanNumberConvert();

            // Act
            int number = romanNumberConvert.Convert("II");

            // Assert
            Assert.AreEqual(2, number);

        }
    }
}
