using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class ReverseLinkedListIITest
    {
        [Theory]
        [MemberData(nameof(InlineData))]
        public void TestMethod(ListNode head, int m, int n, ListNode output)
        {
            Assert.Equal(output, Solution092.ReverseBetween(head, m, n));
        }
        public static IEnumerable<object[]> InlineData
        {
            get
            {
                var driverData = new List<object[]>();
                ListNode head = new ListNode(1);
                head.next = new ListNode(2);
                head.next.next = new ListNode(3);
                head.next.next.next = new ListNode(4);
                head.next.next.next.next = new ListNode(5);
                
                var m = 2;
                var n = 4;
                ListNode output = new ListNode(1);
                output.next = new ListNode(4);
                output.next.next = new ListNode(3);
                output.next.next.next = new ListNode(2);
                output.next.next.next.next = new ListNode(5);
                driverData.Add(new object[] { head,m,n, output });
                
                return driverData;
            }
        } 
    }
}

