﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Practice_3;

namespace Unit_Test
{
    [TestClass]
    public class UnitTest_Calculate_Product
    {
        [TestMethod]
        public void NumbersInRange()
        {
            int x = 11;
            int y = 13;
            int z = 14;

            Task_1 task = new Task_1(x, y, z);
            Assert.AreEqual(2002, task.CalculateProduct());
        }
        [TestMethod]
        public void NoNumbersInRange()
        {
            int x = 10;
            int y = 8;
            int z = 16;
            
            Task_1 task = new Task_1(x, y, z);
            Assert.AreEqual(1, task.CalculateProduct());
        }
        [TestMethod]
        public void OneNumberInrange()
        {
            int x = 12;
            int y = 8;
            int z = 16;

            Task_1 task = new Task_1(x, y, z);
            Assert.AreEqual(12, task.CalculateProduct());
        }
        [TestMethod]
        public void TwoNumbersInrange()
        {
            int x = 12;
            int y = 11;
            int z = 16;

            Task_1 task = new Task_1(x, y, z);
            Assert.AreEqual(132, task.CalculateProduct());
        }
    }

    [TestClass]
    public class UnitTest_Calculate_Product_In_Range
    {
        [TestMethod]
        public void ProductOfNumbersInRange()
        {
            int start = 10;
            int end = 20;
            Task_2 task = new Task_2(start, end);
            Assert.AreEqual(216, task.CalculateProductInRange());
        }
        [TestMethod]
        public void ProductOfNumbersOneInRange()
        {
            int start = 1;
            int end = 9;
            Task_2 task = new Task_2(start, end);
            Assert.AreEqual(6, task.CalculateProductInRange());
        }
        public void ProductOfNumbersNoInRange()
        {
            int start = 1;
            int end = 5;
            Task_2 task = new Task_2(start, end);
            Assert.AreEqual(1, task.CalculateProductInRange());
        }
    }
    [TestClass]
    public class FileReadTests
    {
        [TestMethod]
        public void ShouldReadEmptyFile()
        {
            string patch = @"C:\Users\Kotov\Desktop\empty.txt";
            ArraysAverage a = new ArraysAverage(100);

            FileRead fileReadTests = new FileRead();
            fileReadTests.read(patch, a);
            Assert.AreEqual(0, a.Length);
        }
        [TestMethod]
        public void ShouldReadFileWithValidData()
        {
            string patch = @"C:\Users\Kotov\Desktop\valid.txt";
            ArraysAverage a = new ArraysAverage(100);

            FileRead fileReadTests = new FileRead();
            fileReadTests.read(patch, a);

            Assert.AreEqual(5, a.Length);
            Assert.AreEqual(0, a.a[0]);
            Assert.AreEqual(1, a.a[1]);
            Assert.AreEqual(2, a.a[2]);
            Assert.AreEqual(3, a.a[3]);
            Assert.AreEqual(4, a.a[4]);
        }
    }
    [TestClass]
    public class ArraysAverageTests
    {
        [TestMethod]
        public void ArrayOfPositiveIntegers()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            ArraysAverage average = new ArraysAverage(array.Length);
            average.a = array;
            average.Length = array.Length;

            double result = average.Calculate();
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void ArrayOfNegativeIntegers()
        {
            int[] array = new int[] { -1, -2, -3, -4, -5 };
            ArraysAverage average = new ArraysAverage(array.Length);
            average.a = array;
            average.Length = array.Length;

            double result = average.Calculate();
            Assert.AreEqual(-3, result);
        }
    }
}
