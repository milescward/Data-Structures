using System;
using DataStructures.SinglyLinkedList;
using Xunit;

namespace DataStructures.Tests.SinglyLinkedList.Tests
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void IsEmptyTestTrue()
        {
            var ll = new sgLinkedList();
            ll.Delete(2);
        }

        [Fact]
        public void IsEmptyTestFalse()
        {

        }

        [Fact]
        public void AddTest()
        {
            //Arrange
            var myList = new sgLinkedList();
            myList.Add(new Node(1));
            myList.Add(new Node(2));
            myList.Add(new Node(3));

            //Act
            var expected = 3;
            var actual = myList.Count;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountTest()
        {
            //Arrange
            var ll = new sgLinkedList();
            ll.Add(new Node(1));
            ll.Add(new Node(2));
            ll.Add(new Node(3));
            ll.Delete(3);
            //Act
            var expected = 2;
            var actual = ll.Count;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
