using System;
using DataStructures.SinglyLinkedList;
using Xunit;

namespace DataStructures.Tests.SinglyLinkedList.Tests
{
    public class NodeTests
    {
        [Fact]
        public void DataTest()
        {
            //Arrange
            Node<int> myNode = new Node<int>(1);
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
            var node1 = new Node<int>(1);
            var node2 = new Node<int>(2);
            //Act
            node1.Next = node2;
            var expected = 2;
            var actual = node1.Next.Data;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
