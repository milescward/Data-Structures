using System;
using DataStructures.SortingAlgorithms;
using Xunit;

namespace DataStructures.Tests.SortingAlgorithms.Tests
{
    public class MergeSortTests
    {
        [Fact]
        public void MergeSortTest()
        {
            //Arrange
            var ms = new MergeSort();
            var unsorted = new int[] { 5, 4, 3, 2, 1, 0 };
            var sorted = unsorted;
            //Act
            Array.Sort(sorted);
            var expected = sorted;
            ms.Sort(unsorted);
            var actual = unsorted;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
