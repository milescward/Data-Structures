using System;
using DataStructures.DoublyLinkedList;
using Xunit;

namespace DataStructures.Tests.DoublyLinkedList.Tests
{
    public class DNodeTests
    {
        [Fact]
        public void DataTest()
        {
            //Arrange
            DNode<int> myNode = new DNode<int>(1);
            //Act
            var expected = 1;
            var actual = myNode.Data;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NextTest()
        {
            //Arrange
            var node1 = new DNode<int>(1);
            var node2 = new DNode<int>(2);
            //Act
            node1.Next = node2;
            var expected = 2;
            var actual = node1.Next.Data;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PreviousTest()
        {
            //Arrange
            var node1 = new DNode<int>(1);
            var node2 = new DNode<int>(2);
            //Act
            node2.Previous = node1;
            var expected = 1;
            var actual = node2.Previous.Data;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
