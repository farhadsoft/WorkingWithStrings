﻿using System;

#pragma warning disable CA1062
#pragma warning disable SA1615
#pragma warning disable SA1611

namespace WorkingWithStrings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, source.Length);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            char[] arr = destination.ToCharArray();
            source.CopyTo(0, arr, 0, source.Length);

            return new string(arr);
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            char[] arr = destination.ToCharArray();
            source.CopyTo(0, arr, 4, source.Length);

            return new string(arr);
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            char[] arr = destination.ToCharArray();
            source.CopyTo(2, arr, 5, 6);

            return new string(arr);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            char[] arr = template.ToCharArray();
            regionCode.CopyTo(1, arr, 0, 1);
            locationCode.CopyTo(4, arr, 3, 2);
            dateCode.CopyTo(3, arr, 7, 3);
            factoryCode.CopyTo(2, arr, 12, 4);
            return new string(arr);
        }
    }
}
