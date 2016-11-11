using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class NQueensIITest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, int output)
        {
            Assert.Equal(output, Solution052.TotalNQueens(n));
        }
    }
}

