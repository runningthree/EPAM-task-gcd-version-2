using System;
using NUnit.Framework;
using static Gcd.Version.IntegerExtensions;

namespace Gcd.Version
{
    public class IntegerExtensionsTests
    {
        #region TastCases fo GetGcdByEuclidian
        
        [TestCase(30, 12, ExpectedResult = 6)]
        [TestCase(3, 15, ExpectedResult = 3)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(8, 9, ExpectedResult = 1)]
        [TestCase(50, 250, ExpectedResult = 50)]
        [TestCase(12, 60, ExpectedResult = 12)]
        [TestCase(2672, 5678, ExpectedResult = 334)]
        [TestCase(10927782, 6902514, ExpectedResult = 846)]
        [TestCase(1590771464, 1590771620, ExpectedResult = 4)]
        [TestCase(-7, -7, ExpectedResult = 7)]
        [TestCase(18, 0, ExpectedResult = 18)]
        [TestCase(10927782, -6902514, ExpectedResult = 846)]
        [TestCase(-1590771464, 1590771620, ExpectedResult = 4)]
        [TestCase(-10234562, -7872334, ExpectedResult = 2)]
        [TestCase(1590771464, -1590771620, ExpectedResult = 4)]
        [TestCase(-10234567, -234568989, ExpectedResult = 97)]
        [Timeout(3000)]
        [Order(1)]
        public int GcdTests_WithTwoArguments(int a, int b) => GetGcdByEuclidean(a, b);

        [TestCase(945, 0, ExpectedResult = 945)]
        [TestCase(0, -301, ExpectedResult = 301)]
        [TestCase(10927782, 0, ExpectedResult = 10927782)]
        [TestCase(-1590771464, 0, ExpectedResult = 1590771464)]
        [Timeout(3000)]
        [Order(2)]
        public int GcdTests_WithOneZeroNumber(int a, int b) => GetGcdByEuclidean(a, b);

        [TestCase(100, 60, 40, ExpectedResult = 20)]
        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(100, 60, 16, ExpectedResult = 4)]
        [TestCase(100, -100, -50, ExpectedResult = 50)]
        [TestCase(1, 2, 3, ExpectedResult = 1)]
        [TestCase(-1, -2, -3, ExpectedResult = 1)]
        [TestCase(15, 5, 45, ExpectedResult = 5)]
        [TestCase(0, 0, -1, ExpectedResult = 1)]
        [Timeout(3000)]
        [Order(3)]
        public int GcdTests_WithThreeArguments(int a, int b, int c) => GetGcdByEuclidean(a, b, c);

        [TestCase(0, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 0, ExpectedResult = 1)]
        [TestCase(18, 3, 9, 6, ExpectedResult = 3)]
        [TestCase(-10234567, -234568989, 12358638, 978632483, ExpectedResult = 1)]
        [Timeout(3000)]
        [Order(4)]
        public int GcdTests_WithFourArguments(int a, int b, int c, int d) => GetGcdByEuclidean(a, b, c, d);

        [TestCase(100, 60, 40, ExpectedResult = 20)]
        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(100, 60, 16, ExpectedResult = 4)]
        [TestCase(100, -100, -50, ExpectedResult = 50)]
        [TestCase(1, 2, 3, ExpectedResult = 1)]
        [TestCase(-1, -2, -3, ExpectedResult = 1)]
        [TestCase(15, 5, 45, ExpectedResult = 5)]
        [TestCase(0, 0, -1, ExpectedResult = 1)]
        [TestCase(0, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 0, ExpectedResult = 1)]
        [TestCase(18, 3, 9, 6, ExpectedResult = 3)]
        [TestCase(-10, 35, 90, 55, -105, ExpectedResult = 5)]
        [TestCase(1, 213124, -54654, -123124, 65765, 44444, -7, 1234567, int.MaxValue, ExpectedResult = 1)]
        [TestCase(18, 0, ExpectedResult = 18)]
        [TestCase(12, 21, 91, 17, 0, int.MaxValue, ExpectedResult = 1)]
        [TestCase(3, -3, 3, ExpectedResult = 3)]
        [TestCase(-7, -7, ExpectedResult = 7)]
        [TestCase(123413, 943578, 123413, 943578, 943578, int.MaxValue, ExpectedResult = 1)]
        [Order(5)]
        public int GcdTests_WithDifferentNumbers(params int[] integers) => GetGcdByEuclidean(integers);

        [Test, Order(6)]
        public void GcdTest_WithTwoZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(7)]
        public void GcdTest_WithThreeZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(8)]
        public void GcdTest_WithFourZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0, 0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(9)]
        public void GcdTest_WithAllZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0, 0, 0, 0, 0, 0, 0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(10)]
        public void GcdTest_WithIntMinValue_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0, 0, 0, int.MinValue, 0, 0, 0),
                "int.MinValue cannot be passed to the method, because the execution result can cause the OverflowException.");

        [Test, Order(11)]
        public void GcdTest_3argumentsWithIntMinValue_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(10, 20, int.MinValue),
                "int.MinValue cannot be passed to the method, because the execution result can cause the OverflowException.");

        [Test, Order(12)]
        public void GcdTest_OneArgument_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(10, 20, int.MinValue),
                "Numbers quantity shold be more than 1.");
        
        # endregion TastCases fo GetGcdByEuclidian

        #region TastCases fo GetGcdByStein
        
        [TestCase(30, 12, ExpectedResult = 6)]
        [TestCase(3, 15, ExpectedResult = 3)]
        [TestCase(1, 1, ExpectedResult = 1)]
        [TestCase(8, 9, ExpectedResult = 1)]
        [TestCase(50, 250, ExpectedResult = 50)]
        [TestCase(12, 60, ExpectedResult = 12)]
        [TestCase(2672, 5678, ExpectedResult = 334)]
        [TestCase(10927782, 6902514, ExpectedResult = 846)]
        [TestCase(1590771464, 1590771620, ExpectedResult = 4)]
        [TestCase(-7, -7, ExpectedResult = 7)]
        [TestCase(18, 0, ExpectedResult = 18)]
        [TestCase(10927782, -6902514, ExpectedResult = 846)]
        [TestCase(-1590771464, 1590771620, ExpectedResult = 4)]
        [TestCase(-10234562, -7872334, ExpectedResult = 2)]
        [TestCase(1590771464, -1590771620, ExpectedResult = 4)]
        [TestCase(-10234567, -234568989, ExpectedResult = 97)]
        [Timeout(3000)]
        [Order(13)]
        public int GcdTests_WithTwoArgumentsByStein(int a, int b) => GetGcdByStein(a, b);

        [TestCase(945, 0, ExpectedResult = 945)]
        [TestCase(0, -301, ExpectedResult = 301)]
        [TestCase(10927782, 0, ExpectedResult = 10927782)]
        [TestCase(-1590771464, 0, ExpectedResult = 1590771464)]
        [Timeout(3000)]
        [Order(14)]
        public int GcdTests_WithOneZeroNumberByStein(int a, int b) => GetGcdByStein(a, b);

        [TestCase(100, 60, 40, ExpectedResult = 20)]
        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(100, 60, 16, ExpectedResult = 4)]
        [TestCase(100, -100, -50, ExpectedResult = 50)]
        [TestCase(1, 2, 3, ExpectedResult = 1)]
        [TestCase(-1, -2, -3, ExpectedResult = 1)]
        [TestCase(15, 5, 45, ExpectedResult = 5)]
        [TestCase(0, 0, -1, ExpectedResult = 1)]
        [Timeout(3000)]
        [Order(15)]
        public int GcdTests_WithThreeArgumentsByStein(int a, int b, int c) => GetGcdByStein(a, b, c);

        [TestCase(0, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 0, ExpectedResult = 1)]
        [TestCase(18, 3, 9, 6, ExpectedResult = 3)]
        [TestCase(-10234567, -234568989, 12358638, 978632483, ExpectedResult = 1)]
        [Timeout(3000)]
        [Order(16)]
        public int GcdTests_WithFourArgumentsByStein(int a, int b, int c, int d) => GetGcdByStein(a, b, c, d);

        [TestCase(100, 60, 40, ExpectedResult = 20)]
        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(100, 60, 16, ExpectedResult = 4)]
        [TestCase(100, -100, -50, ExpectedResult = 50)]
        [TestCase(1, 2, 3, ExpectedResult = 1)]
        [TestCase(-1, -2, -3, ExpectedResult = 1)]
        [TestCase(15, 5, 45, ExpectedResult = 5)]
        [TestCase(0, 0, -1, ExpectedResult = 1)]
        [TestCase(0, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 0, ExpectedResult = 1)]
        [TestCase(18, 3, 9, 6, ExpectedResult = 3)]
        [TestCase(-10, 35, 90, 55, -105, ExpectedResult = 5)]
        [TestCase(1, 213124, -54654, -123124, 65765, 44444, -7, 1234567, int.MaxValue, ExpectedResult = 1)]
        [TestCase(18, 0, ExpectedResult = 18)]
        [TestCase(12, 21, 91, 17, 0, int.MaxValue, ExpectedResult = 1)]
        [TestCase(3, -3, 3, ExpectedResult = 3)]
        [TestCase(-7, -7, ExpectedResult = 7)]
        [TestCase(123413, 943578, 123413, 943578, 943578, int.MaxValue, ExpectedResult = 1)]
        [Order(17)]
        public int GcdTests_WithDifferentNumbersByStein(params int[] integers) => GetGcdByStein(integers);

        [Test, Order(18)]
        public void GetGcdBySteinTest_WithTwoZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(19)]
        public void GetGcdBySteinTest_WithThreeZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(20)]
        public void GetGcdBySteinTest_WithFourZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0, 0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(21)]
        public void GetGcdBySteinTest_WithAllZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0, 0, 0, 0, 0, 0, 0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(22)]
        public void GetGcdBySteinTest_WithIntMinValue_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0, 0, 0, int.MinValue, 0, 0, 0),
                "int.MinValue cannot be passed to the method, because the execution result can cause the OverflowException.");

        [Test, Order(23)]
        public void GetGcdBySteinTest_3argumentsWithIntMinValue_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(10, 20, int.MinValue),
                "int.MinValue cannot be passed to the method, because the execution result can cause the OverflowException.");

        [Test, Order(24)]
        public void GetGcdBySteinTest_OneArgument_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(10, 20, int.MinValue),
                "Numbers quantity shold be more than 1.");
        
        #endregion TastCases fo GetGcdByStein
    }
}