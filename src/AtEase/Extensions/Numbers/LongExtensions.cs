﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AtEase.Extensions.Numbers
{
    public static class LongExtensions
    {
        /// <summary>
        /// Indicates the value as long  is 0 or long.MinValue value.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is 0 or min value.</returns>
        public static bool IsZeroOrMin(this long value)
        {
            return value == long.MinValue || value == 0;
        }
        /// <summary>
        /// Indicates the value is even.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is even.</returns>
        public static bool IsEven(this long value)
        {
            return value % 2 == 0;
        }
        /// <summary>
        /// Indicates the value is odd.
        /// </summary>
        /// <param name="value">Long value</param>
        /// <returns>Returns true if value is odd.</returns>
        public static bool IsOdd(this long value)
        {
            return !IsEven(value);
        }
        /// <summary>
        /// Create random long number
        /// </summary>
        /// <returns>Random long number</returns>
        public static long NextRandom()
        {
            using var provider = new RNGCryptoServiceProvider();

            var data = new byte[8];

            provider.GetBytes(data);

            var randomNumber = BitConverter.ToInt64(data, 0);

            return Math.Abs(randomNumber);
        }

    }
}
