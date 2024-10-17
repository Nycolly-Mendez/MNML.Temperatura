using MNML.ESFE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MNML.Temperatura.UnitTestxUnit
{
    public class StringManipulatorTest
    {
        private StringManipulator _manipulator;

        public StringManipulatorTest()
        {
            _manipulator = new StringManipulator();
        }

        [Fact]
        public void ReverseString_ShouldReturnReversedString()
        {
            // Arrange
            string input = "hello";
            string expected = "olleh";

            // Act
            string result = _manipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveSpaces_ShouldReturnStringWithoutSpaces()
        {
            // Arrange
            string input = "hello world";
            string expected = "helloworld";

            // Act
            string result = _manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}