using CodeToBeTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TDDandUnitTesting
{
    public class NumCheckerTest
    {
        [Theory]
        [InlineData(4,"EVEN")]
        [InlineData(9, "ODD")]
        [InlineData(3, "PRIME")]
        [InlineData(2, "PRIME")]
        [InlineData(1, "PRIME")]
        public void TestCheckNum(int input, string expected)
        {
            NumChecker nc = new NumChecker();
            string actual = nc.CheckNum(input);

            Assert.Equal(expected, actual);
        }
    }
}
