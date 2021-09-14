using System;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            int foo;
            while (a != 0)
            {
                foo = a;
                a = b % a;
                b = foo;
            }

            b = Math.Abs(b);
            return b;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
            }

            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            return (a == 0 && b == 0) ? GetGcdByEuclidean(a, GetGcdByEuclidean(b, c))
                : GetGcdByEuclidean(b, GetGcdByEuclidean(a, c));
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            int lengthOfParams, result;
            lengthOfParams = other.Length;
            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] == 0)
                {
                    lengthOfParams--;
                }

                if (other[i] == int.MinValue)
                {
                    lengthOfParams = -1;
                }
            }

            if (a == 0 && b == 0 && lengthOfParams == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
            }

            if (a == int.MinValue || b == int.MinValue || lengthOfParams == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            result = (a == 0 && b == 0) ? 0 : GetGcdByEuclidean(a, b);
            foreach (int item in other)
            {
                result = (result == 0 && item == 0) ? 0 : GetGcdByEuclidean(result, item);
            }

            return result;
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            int k;
            for (k = 0; ((a | b) & 1) == 0; ++k)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
            {
                a >>= 1;
            }

            do
            {
                while ((b & 1) == 0)
                {
                    b >>= 1;
                }

                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }

                b -= a;
            }
            while (b != 0);
            return a << k;
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
            }

            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            return (a == 0 && b == 0) ? GetGcdByStein(a, GetGcdByStein(b, c))
                : GetGcdByStein(b, GetGcdByStein(a, c));
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            int lengthOfParams, result;
            lengthOfParams = other.Length;
            for (int i = 0; i < other.Length; i++)
            {
                if (other[i] == 0)
                {
                    lengthOfParams--;
                }

                if (other[i] == int.MinValue)
                {
                    lengthOfParams = -1;
                }
            }

            if (a == 0 && b == 0 && lengthOfParams == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.", nameof(a));
            }

            if (a == int.MinValue || b == int.MinValue || lengthOfParams == -1)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"Number cannot be {int.MinValue}.");
            }

            result = (a == 0 && b == 0) ? 0 : GetGcdByStein(a, b);
            foreach (int item in other)
            {
                result = (result == 0 && item == 0) ? 0 : GetGcdByStein(result, item);
            }

            return result;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            System.Diagnostics.Stopwatch time = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b);
            time.Stop();
            elapsedTicks = time.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            System.Diagnostics.Stopwatch time = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b, c);
            time.Stop();
            elapsedTicks = time.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            System.Diagnostics.Stopwatch time = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByEuclidean(a, b, other);
            time.Stop();
            elapsedTicks = time.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            System.Diagnostics.Stopwatch time = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByStein(a, b);
            time.Stop();
            elapsedTicks = time.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            System.Diagnostics.Stopwatch time = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByStein(a, b, c);
            time.Stop();
            elapsedTicks = time.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            System.Diagnostics.Stopwatch time = System.Diagnostics.Stopwatch.StartNew();
            int result = GetGcdByStein(a, b, other);
            time.Stop();
            elapsedTicks = time.ElapsedTicks;
            return result;
        }
    }
}
