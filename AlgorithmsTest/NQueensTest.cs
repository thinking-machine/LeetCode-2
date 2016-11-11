using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class NQueensTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int n, IList<IList<string>> output)
        {
            Assert.Equal(output, Solution051.SolveNQueens(n));
        }
    }
}

