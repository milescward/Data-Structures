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
            //Arrange
            var ll = new mySinglyLinkedList<int>();
            ll.Add(1);
            //Act
            var expected = false;
            var actual = ll.IsEmpty;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsEmptyTestTrue()
        {
            //Arrange
            var ll = new mySinglyLinkedList<int>();
            //Act
            var actual = ll.IsEmpty;
            var expected = true;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteFirstTest()
        {
            //Arrange
            var myList = new mySinglyLinkedList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Act
            myList.Delete(3);
            var expected = 2;
            var actual = myList.Count;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteLastTest()
        {
            //Arrange
            var myList = new mySinglyLinkedList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Act
            myList.Delete(1);
            var expected = 2;
            var actual = myList.Count;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteNullTest()
        {
            //Arrange
            var myList = new mySinglyLinkedList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Act
            myList.Delete(4);
            var expected = 3;
            var actual = myList.Count;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddTest()
        {
            //Arrange
            var myList = new mySinglyLinkedList<int>();
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
            var myList = new mySinglyLinkedList<int>();
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

        [Fact]
        public void DisplayTest()
        {
            //Arrange
            var ll = new mySinglyLinkedList<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(3);

            //Act
            var expected = "3 ->  2 ->  1 ->  ";
            var actual = ll.Display();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
