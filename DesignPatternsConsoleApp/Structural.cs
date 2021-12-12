// <copyright file="Structural.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPatternsConsoleApp
{
    using System;

    using Adapter;

    /// <summary>
    /// This class implements all structural design patterns.
    /// </summary>
    public static class Structural
    {
        /// <summary>
        /// An example of Adapter pattern implementation.
        /// </summary>
        public static void AdapterExample()
        {
            Console.WriteLine("Start - Calling Structural - Adapter Example 1 ...");
            Console.WriteLine("Which type of file extension, do you want to convert from? ");
            Console.WriteLine("0:.txt, 1:.rtf, 2:.doc, 3:.docx, 4:.xls, 5:.xlsx, 6:.pdf ");
            var convertFrom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which type of file extension, do you want to convert to? ");
            Console.WriteLine("0:.txt, 1:.rtf, 2:.doc, 3:.docx, 4:.xls, 5:.xlsx, 6:.pdf ");
            var convertTo = Convert.ToInt32(Console.ReadLine());

            var decisionMaker = new DecisionMaker();
            Console.WriteLine(decisionMaker.StartConversion(NumberToExtention(convertFrom), NumberToExtention(convertTo)));

            Console.WriteLine("End - Calling Structural - Adapter Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Converts to integer input to string type.
        /// </summary>
        /// <param name="convertFrom">integer.</param>
        /// <returns>string.</returns>
        private static string NumberToExtention(int convertFrom)
        {
            return convertFrom switch
            {
                1 => ".rtf",
                2 => ".doc",
                3 => ".docx",
                4 => ".xls",
                5 => ".xlsx",
                6 => ".pdf",
                _ => ".txt",
            };
        }
    }
}