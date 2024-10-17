using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MNML.ESFE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MNML.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit_ShouldConvertCorrectly()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 25;

            // Act
            double result = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(77, result);
        }

        [TestMethod]
        public void FahrenheitToCelsius_ShouldConvertCorrectly()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 77;

            // Act
            double result = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(25, result, 0.001);
        }
    }
}
