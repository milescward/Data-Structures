using System;
using DataStructures.SortingAlgorithms;
using Xunit;

namespace DataStructures.Tests.SortingAlgorithms.Tests
{
    public class InsertionSortTests
    {
        [Fact]
        public void SelectionSortTest()
        {
            //Arrange
            var IS = new InsertionSort();
            var arr = new int[] { 3, 2, 6, 8, 1, 2 };
            //Act
            var expected = new int[] { 1, 2, 2, 3, 6, 8 };
            var actual = IS.Sort(arr);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
