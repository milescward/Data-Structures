using System;
using DataStructures.BinaryTree;
using Xunit;

namespace DataStructures.Tests.BinaryTree.Tests
{
    public class myBinaryTreeTests
    {
        [Fact]
        public void InsertTest()
        {
            //Arrange
            var bt = new myBinaryTree();
            bt.Insert(3);
            bt.Insert(2);
            bt.Insert(4);
            //Act
            var expected = 3;
            var actual = bt.Count;
            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void DisplayTest()
        {
            //Arrange
            var bt = new myBinaryTree();
            bt.Insert(3);
            bt.Insert(2);
            bt.Insert(4);
            bt.Insert(1);
            bt.Insert(5);
            bt.Insert(0);
            bt.Insert(6);
            //Act
            var expected = "0 1 2 3 4 5 6 ";
            var actual = bt.Display();
            //Assert
            Assert.Equal(expected, actual);
        }


        
        [Fact]
        public void CountTest()
        {
            //Arrange
            var bt = new myBinaryTree();
            bt.Insert(3);
            bt.Insert(2);
            bt.Insert(4);
            bt.Insert(1);
            //Act
            var expected = 4;
            var actual = bt.Count;
            //Assert
            Assert.Equal(expected, actual);
        }

        
        [Fact]
        public void PreorderTraversalTest()
        {
            //Arrange
            var bt = new myBinaryTree();
            bt.Insert(3);
            bt.Insert(2);
            bt.Insert(4);
            bt.Insert(1);
            bt.Insert(5);
            bt.Insert(0);
            bt.Insert(6);
            //Act
            var expected = "3 2 1 0 4 5 6";
            //var temp = bt.PreorderTraversal();
            var actual = string.Join(" ", bt.PreorderTraversal());
            //Assert
            Assert.Equal(expected, actual);
        }


        /*
        [Fact]
        public void Test()
        {
            //Arrange
            //Act
            //Assert
        }
        */
    }
}
