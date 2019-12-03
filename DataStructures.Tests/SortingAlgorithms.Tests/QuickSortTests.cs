using System;
using DataStructures.SortingAlgorithms;
using Xunit;

namespace DataStructures.Tests.SortingAlgorithms.Tests
{
    public class QuickSortTests
    {
        [Fact]
        public void QuickSortTest()
        {
            //Arrange
            var qs = new QuickSort();
            var arr = new int[] { 6, 4, 7, 1, 8, 5 };
            //Act
            var expected = new int[] { 1, 4, 5, 6, 7, 8 };
            qs.Sort(arr);
            var actual = arr;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
