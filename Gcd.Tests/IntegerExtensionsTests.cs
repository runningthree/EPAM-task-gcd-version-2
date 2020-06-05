using System;
using NUnit.Framework;
using static Gcd.IntegerExtensions;

namespace Gcd.Tests
{
    public class IntegerExtensionsTests
    {
        #region TastCases fo GetGcdByEuclidian
        
        [TestCase(30, 12, ExpectedResult = 6)]
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
        [TestCase(945, 0, ExpectedResult = 945)]
        [TestCase(0, -301, ExpectedResult = 301)]
        [TestCase(10927782, 0, ExpectedResult = 10927782)]
        [TestCase(-1590771464, 0, ExpectedResult = 1590771464)]
        public int GetGcdByEuclidean_WithTwoArguments(int a, int b) => GetGcdByEuclidean(a, b);

        [TestCase(100, 60, 40, ExpectedResult = 20)]
        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(100, 60, 16, ExpectedResult = 4)]
        [TestCase(100, -100, -50, ExpectedResult = 50)]
        [TestCase(1, 2, 3, ExpectedResult = 1)]
        [TestCase(-1, -2, -3, ExpectedResult = 1)]
        [TestCase(15, 5, 45, ExpectedResult = 5)]
        [TestCase(0, 0, -1, ExpectedResult = 1)]
        public int GetGcdByEuclidean_WithThreeArguments(int a, int b, int c) => GetGcdByEuclidean(a, b, c);
        
        [TestCase(-10, 35, 90, 55, -105, ExpectedResult = 5)]
        [TestCase(1, 213124, -54654, -123124, 65765, 44444, -7, 1234567, int.MaxValue, ExpectedResult = 1)]
        [TestCase(18, 0, ExpectedResult = 18)]
        [TestCase(12, 21, 91, 17, 0, int.MaxValue, ExpectedResult = 1)]
        [TestCase(3, -3, 3, ExpectedResult = 3)]
        [TestCase(-7, -7, ExpectedResult = 7)]
        [TestCase(123413, 943578, 123413, 943578, 943578, int.MaxValue, ExpectedResult = 1)]
        public int GetGcdByEuclidean_WithParams(params int[] integers) => GetGcdByEuclidean(integers);

        [Test]
        public void GetGcdByEuclidean_WithTwoZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test]
        public void GetGcdByEuclidean_WithThreeZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test, Order(9)]
        public void GetGcdByEuclidean_WithAllZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0, 0, 0, 0, 0, 0, 0, 0),
                "All numbers cannot be 0 at the same time.");
        
        # endregion TastCases fo GetGcdByEuclidian

        #region TastCases fo GetGcdByStein
        
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
        [TestCase(945, 0, ExpectedResult = 945)]
        [TestCase(0, -301, ExpectedResult = 301)]
        [TestCase(10927782, 0, ExpectedResult = 10927782)]
        [TestCase(-1590771464, 0, ExpectedResult = 1590771464)]
        public int GetGcdByStein_WithTwoArguments(int a, int b) => GetGcdByStein(a, b);

        [TestCase(100, 60, 40, ExpectedResult = 20)]
        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(100, 60, 16, ExpectedResult = 4)]
        [TestCase(100, -100, -50, ExpectedResult = 50)]
        [TestCase(-1, -2, -3, ExpectedResult = 1)]
        [TestCase(15, 5, 45, ExpectedResult = 5)]
        [TestCase(0, 0, -1, ExpectedResult = 1)]
        public int GetGcdByStein_WithThreeArguments(int a, int b, int c) => GetGcdByStein(a, b, c);
        
        [TestCase(0, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 0, ExpectedResult = 1)]
        [TestCase(18, 3, 9, 6, ExpectedResult = 3)]
        [TestCase(-10, 35, 90, 55, -105, ExpectedResult = 5)]
        [TestCase(1, 213124, -54654, -123124, 65765, 44444, -7, 1234567, int.MaxValue, ExpectedResult = 1)]
        [TestCase(12, 21, 91, 17, 0, int.MaxValue, ExpectedResult = 1)]
        [TestCase(123413, 943578, 123413, 943578, 943578, int.MaxValue, ExpectedResult = 1)]
        public int GetGcdByStein_WithParams(params int[] integers) => GetGcdByStein(integers);

        [Test]
        public void GetGcdByStein_WithTwoZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0),
                "All numbers cannot be 0 at the same time.");

        [Test]
        public void GetGcdByStein_WithThreeZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0, 0),
                "All numbers cannot be 0 at the same time.");
        
        [Test]
        public void GetGcdByStein_WithAllZeroNumbers_ThrowArgumentException() =>
            Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0, 0, 0, 0, 0, 0, 0, 0),
                "All numbers cannot be 0 at the same time.");
        
        #endregion TastCases fo GetGcdByStein
    }
}