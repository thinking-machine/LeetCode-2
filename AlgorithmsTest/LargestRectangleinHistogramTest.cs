using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class LargestRectangleinHistogramTest
    {
        [Theory]
        [InlineData(new[]{1,2}, 1)]
        public void TestMethod(int[] heights, int output)
        {
            Assert.Equal(output, Solution084.LargestRectangleArea(heights));
        }
    }
}

