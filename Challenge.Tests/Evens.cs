using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge.Evens;

namespace Challenge.Tests
{
    [TestClass]
    public class Evens
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullArray()
        {
            //Arrange
            int[] array = null;
            //Act
            var output = CopyEvens.Copy(array);

            //Assert
            //Not needed
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEmptyArray()
        {
            //Arrange
            int[] array = new int[0];

            //Act
            var output = CopyEvens.Copy(array);

            //Assert
            //Not needed
        }

        [TestMethod]
        public void TestRegularArray()
        {
            //Arrange
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expectedOutput = new int[] { 2, 4, 6, 8, 10 };

            //Act
            var output = CopyEvens.Copy(array);

            //Assert
            CollectionAssert.AreEqual(output, expectedOutput);
        }

        [TestMethod]
        public void TestEvensArray()
        {
            //Arrange
            int[] array = new int[] { 2, 4, 6, 8, 10 };
            int[] expectedOutput = new int[] { 2, 4, 6, 8, 10 };

            //Act
            var output = CopyEvens.Copy(array);

            //Assert
            CollectionAssert.AreEqual(output, expectedOutput);
        }

        [TestMethod]
        public void TestOddArray()
        {
             //Arrange
            int[] array = new int[] { 1, 3, 5, 7, 9 };
            int[] expectedOutput = new int[0];

            //Act
            var output = CopyEvens.Copy(array);

            //Assert
            CollectionAssert.AreEqual(output, expectedOutput);
        }
    }
}
