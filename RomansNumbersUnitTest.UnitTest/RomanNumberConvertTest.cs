using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomansNumbersUnitTest.UnitTest
{
    [TestClass]
    public class RomanNumberConvertTest
    {
        private RomanNumberConvert _romanNumberConvert;
        [TestInitialize]
        public void TestInitialize()
        {
            _romanNumberConvert = new RomanNumberConvert();
        }

        [TestMethod]
        public void Should_Understand_the_I_Simbol()
        {
            // Arrange
            
            // Act
            int number = _romanNumberConvert.Convert("I");

            // Assert
            Assert.AreEqual(1,number);

        }

        [TestMethod]
        public void Should_Understand_the_V_Simbol()
        {
            // Arrange

            // Act
            int number = _romanNumberConvert.Convert("V");

            // Assert
            Assert.AreEqual(5, number);

        }


        [TestMethod]
        public void Should_Understand_Simbols_Like_II_()
        {
            // Arrange

            // Act
            int number = _romanNumberConvert.Convert("II");

            // Assert
            Assert.AreEqual(2, number);

        }

        [TestMethod]
        public void Should_Understand_Simbols_Like_XXII_()
        {
            // Arrange

            // Act
            int number = _romanNumberConvert.Convert("XXII");

            // Assert
            Assert.AreEqual(22, number);

        }

        [TestMethod]
        public void Should_Understand_Simbols_Like_IV_()
        {
            // Arrange

            // Act
            int number = _romanNumberConvert.Convert("IV");

            // Assert
            Assert.AreEqual(4, number);

        }


        [TestMethod]
        public void Should_Understand_Simbols_Like_XXIV_()
        {
            // Arrange

            // Act
            int number = _romanNumberConvert.Convert("XXIV");

            // Assert
            Assert.AreEqual(24, number);

        }
    }
}
