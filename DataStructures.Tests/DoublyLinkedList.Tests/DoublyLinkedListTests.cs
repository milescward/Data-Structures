using System;
using DataStructures.DoublyLinkedList;
using Xunit;

namespace DataStructures.Tests.DoublyLinkedList.Tests
{
    public class DoublyLinkedListTests
    {
        [Fact]
        public void IsEmptyTestFalse()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            dll.AddFront(1);
            //Act
            var expected = false;
            var actual = dll.IsEmpty;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsEmptyTestTrue()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            //Act
            var expected = true;
            var actual = dll.IsEmpty;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddFrontTest()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            dll.AddFront(1);
            dll.AddFront(2);
            dll.AddFront(3);
            //Act
            var expected = 3;
            var actual = dll.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddBackTest()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            dll.AddBack(1);
            dll.AddBack(2);
            dll.AddBack(3);
            //Act
            var expected = 3;
            var actual = dll.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteFirstTest()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            dll.AddFront(1);
            dll.AddFront(2);
            dll.AddFront(3);
            dll.AddFront(4);
            //Act
            dll.Delete(4);
            var expected = 3;
            var actual = dll.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteLastTest()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            dll.AddFront(1);
            dll.AddFront(2);
            dll.AddFront(3);
            dll.AddFront(4);
            //Act
            dll.Delete(1);
            var expected = 2;
            var actual = dll.Tail.Data;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteNullTest()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            dll.AddFront(1);
            dll.AddFront(2);
            dll.AddFront(3);
            dll.AddFront(4);
            //Act
            dll.Delete(7);
            var expected = 4;
            var actual = dll.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertTest()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            dll.AddFront(1);
            dll.AddFront(2);
            dll.AddFront(3);
            dll.AddFront(4);
            //Act
            dll.Insert(dll.Head.Next, dll.Head.Next.Next, 7);
            var expected = 5;
            var actual = dll.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertAfterOneNodeTest()
        {
            //Arrange
            var dll = new myDoublyLinkedList<int>();
            dll.AddFront(1);
            dll.AddFront(2);
            dll.AddFront(3);
            dll.AddFront(4);
            //Act
            dll.Insert(dll.Head.Next, 7);
            var expected = 5;
            var actual = dll.Count;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
