using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Calculator;

namespace TDDandUnitTesting
{
    public class TestCalculator
    {
        //This is a tag, which goes over a method to tell C# to treat it as a test
        [Fact]
        public void TestAdd()
        {
            //Arrange 
            int expected = 5;
            CalculatorClass c = new CalculatorClass();


            //Act
            int actual = c.Add(2, 3);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd2()
        {
            int expected = 11;
            CalculatorClass c = new CalculatorClass();

            int actual = c.Add(5, 6);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,7, 12)]
        [InlineData(-3,8, 5)]
        [InlineData(-1,9, 8)]
        [InlineData(-1,-10, -11)]
        public void TestAddTheory(int x, int y, int expected)
        {
            CalculatorClass c = new CalculatorClass();
            int actual = c.Add(x, y);

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,7, -2)]
        [InlineData(10,4, 6)]
        [InlineData(-3,8, -11)]
        public void TestMinus(int x, int y, int expected)
        {
            CalculatorClass c = new CalculatorClass();
            int actual = c.Minus(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
