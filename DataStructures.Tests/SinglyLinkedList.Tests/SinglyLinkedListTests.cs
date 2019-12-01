using System;
using DataStructures.SinglyLinkedList;
using Xunit;

namespace DataStructures.Tests.SinglyLinkedList.Tests
{
    public class SinglyLinkedListTests
    {
        [Fact]
        public void IsEmptyTestFalse()
        {
            var ll = new mySinglyLinkedList();
            ll.Add(1);
        }

        [Fact]
        public void IsEmptyTestTrue()
        {
            //Arrange
            var ll = new mySinglyLinkedList();
            //Act
            var actual = ll.IsEmpty;
            var expected = true;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddTest()
        {
            //Arrange
            var myList = new mySinglyLinkedList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

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
            var myList = new mySinglyLinkedList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Delete(3);
            //Act
            var expected = 2;
            var actual = myList.Count;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
