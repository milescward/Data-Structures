using System;
using DataStructures.SortingAlgorithms;
using Xunit;

namespace DataStructures.Tests.SortingAlgorithms.Tests
{
    public class BubbleSortTests
    {
        [Fact]
        public void BubbleSortTest()
        {
            //Arrange
            var bs = new BubbleSort();
            var arr = new int[] { 3, 2, 6, 8, 1, 2 };
            //Act
            var expected = new int[] { 1, 2, 2, 3, 6, 8 };
            var actual = bs.Sort(arr);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
