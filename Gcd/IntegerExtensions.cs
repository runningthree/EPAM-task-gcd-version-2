using System;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        #region GetGcdByEuclidean Methods

        /// <summary>
        /// Calculates GCD of two integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of three integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates the GCD of integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="integers">Source integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Throw when all numbers are 0 at the same time.
        /// -or- when length of integers is one.</exception>
        /// <exception cref="ArgumentNullException">Throw when integers equals null.</exception>
        public static int GetGcdByEuclidean(params int[] integers)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        #endregion

        #region GetGcdByStein methods

        /// <summary>
        /// Calculates GCD of two integers by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GSD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of three integers by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GSD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates the GCD of integers by the Stein algorithm.
        /// </summary>
        /// <param name="integers">Source integers.</param>
        /// <returns>The GSD value.</returns>
        /// <exception cref="ArgumentException">Throw when all numbers are 0 at the same time.
        /// -or- when length of integers is one.</exception>
        /// <exception cref="ArgumentNullException">Throw when integers equals null.</exception>
        public static int GetGcdByStein(params int[] integers)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        #endregion GetGcdByStein methods

        #region GetGcdEuclidian with elapsed time Methods

        /// <summary>
        /// Calculates GCD of two integers by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="a">First integer for GCD.</param>
        /// <param name="b">Second integer for GCD.</param>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        public static int GetGcdByEuclidean(int a, int b, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of three integers by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="a">First integer for GCD.</param>
        /// <param name="b">Second integer for GCD.</param>
        /// <param name="c">Third integer for GCD.</param>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        public static long GetGcdByEuclidean(int a, int b, int c, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates the GCD of integers by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="integers">Source integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Throw when all numbers are 0 at the same time.
        /// -or- when length of integers is one.</exception>
        /// <exception cref="ArgumentNullException">Throw when integers equals null.</exception>
        public static long GetGcdByEuclidean(out double elapsedTicks, params int[] integers)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        #endregion GetGcdEuclidian with elapsed time Methods

        #region GetGcdByStein with elapsed time Methods
        /// <summary>
        /// Calculates GCD of two integers by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        public static int GetGcdByStein(int a, int b, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of three integers by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        public static long GetGcdByStein(int a, int b, int c, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates the GCD of integers by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="parameters">Source integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- when length of integers is one.</exception>
        /// <exception cref="ArgumentNullException">Thrown when integers equals null.</exception>
        public static long GetGcdByStein(out double elapsedTicks, params int[] parameters)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        #endregion GetGcdByStein with elapsed time Methods

    }
}