using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SpiralMatrixTest
    {
        [Theory]
        [InlineData()]
        public void TestMethod(int[,] matrix, IList<int> output)
        {
            Assert.Equal(output, Solution054.SpiralOrder(matrix));
        }
    }
}

