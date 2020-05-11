using System;
using System.Diagnostics;

namespace Gcd.Version
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
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of Three integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when three numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of four integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <param name="d">Fourth integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c, int d)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates the GCD of (integers.Length) integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="integers">N integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.
        /// -or- Thrown when only one argument is placed in the method parameters.</exception>
        /// <exception cref="ArgumentNullException">Thrown when params int[] integers equals null.</exception>
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
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
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
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of four integers by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <param name="d">Fourth integer.</param>
        /// <returns>The GSD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c, int d)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates the GCD of (integers.Length) integers by the Stein algorithm.
        /// </summary>
        /// <param name="integers">N integers.</param>
        /// <returns>The GSD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.
        /// -or- Thrown when only one argument is placed in the method parameters.</exception>
        /// <exception cref="ArgumentNullException">Thrown when params int[] integers equals null.</exception>
        public static int GetGcdByStein(params int[] integers)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        #endregion GetGcdByStein methods

        #region GetGcdEuclidian with elapsed time Methods

        /// <summary>
        /// Calculates GCD of two integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer for GCD.</param>
        /// <param name="b">Second integer for GCD.</param>
        /// <param name="elapsedTicks"> Method execution time in ticks. </param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of three integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer for GCD.</param>
        /// <param name="b">Second integer for GCD.</param>
        /// <param name="c">Third integer for GCD.</param>
        /// <param name="elapsedTicks"> Method execution time in ticks. </param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static long GetGcdByEuclidean(int a, int b, int c, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of four integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer for GCD.</param>
        /// <param name="b">Second integer for GCD.</param>
        /// <param name="c">Third integer for GCD.</param>
        /// <param name="d">Fourth integer for GCD.</param>
        /// <param name="elapsedTicks"> Method execution time in Ticks. </param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static long GetGcdByEuclidean(int a, int b, int c, int d, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates the GCD of (integers.Length) integers by the Euclidean algorithm.
        /// </summary>
        /// <param name="elapsedTicks"> Method execution time in Ticks. </param>
        /// <param name="parameters">(parameter.Length) integers for GCD.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        /// <exception cref="ArgumentNullException">Thrown when params int[] integers equals null.</exception>
        public static long GetGcdByEuclidean(out double elapsedTicks, params int[] parameters)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        #endregion GetGcdEuclidian with elapsed time Methods

        #region GetGcdByStein with elapsed time Methods

        /// <summary>
        /// Calculates GCD of two integers by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer for GCD.</param>
        /// <param name="b">Second integer for GCD.</param>
        /// <param name="elapsedTicks"> Method execution time in ticks. </param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of three integers by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer for GCD.</param>
        /// <param name="b">Second integer for GCD.</param>
        /// <param name="c">Third integer for GCD.</param>
        /// <param name="elapsedTicks"> Method execution time in ticks. </param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static long GetGcdByStein(int a, int b, int c, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates GCD of four integers by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer for GCD.</param>
        /// <param name="b">Second integer for GCD.</param>
        /// <param name="c">Third integer for GCD.</param>
        /// <param name="d">Fourth integer for GCD.</param>
        /// <param name="elapsedTicks"> Method execution time in Ticks. </param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        public static long GetGcdByStein(int a, int b, int c, int d, out double elapsedTicks)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        /// <summary>
        /// Calculates the GCD of (integers.Length) integers by the Stein algorithm.
        /// </summary>
        /// <param name="elapsedTicks"> Method execution time in Ticks. </param>
        /// <param name="parameters">(parameter.Length) integers for GCD.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.
        /// -or- Thrown when one of the arguments is int.MinValue.</exception>
        /// <exception cref="ArgumentNullException">Thrown when params int[] integers equals null.</exception>
        public static long GetGcdByStein(out double elapsedTicks, params int[] parameters)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        #endregion GetGcdByStein with elapsed time Methods

    }
}