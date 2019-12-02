using System;
using DataStructures.Queue;
using Xunit;

namespace DataStructures.Tests.Stack.Tests
{
    public class StackTests
    {
        [Fact]
        public void PushTest()
        {
            //Arrange
            var stack = new myStack<int>();
            stack.Push(1);
            //Act
            var expected = 1;
            var actual = stack.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PopTest()
        {
            //Arrange
            var stack = new myStack<int>();
            stack.Push(1);
            stack.Push(2);
            //Act
            stack.Pop();
            var expected = 1;
            var actual = stack.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PeekTest()
        {
            //Arrange
            var stack = new myStack<int>();
            stack.Push(1);
            stack.Push(2);
            //Act
            var expected = 2;
            var actual = stack.Peek();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
