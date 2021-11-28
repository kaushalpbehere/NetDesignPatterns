// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPatternsConsoleApp
{
    using System;

    using Creational.AbstractFactory.Example1.TypeOfMachines;
    using Creational.Factory.Example1;

    /// <summary>
    /// The start of the DesignPatterns.
    /// </summary>
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Which program would you like to run? ");
            Console.WriteLine("100: Exit, 0: Factory, 1: Abstract Factory ");
            var message = Convert.ToInt32(Console.ReadLine());
            switch (message)
            {
                case 0:
                    FactoryExample();
                    break;
                case 1:
                    AbstractFactoryExample();
                    break;
                case 2:
                    AbstractFactoryExample();
                    break;
                case 100:
                    Console.WriteLine("Thank you !!!");
                    break;
            }

            Console.WriteLine("Press any key to exit the program ...");
        }

        /// <summary>
        /// Abstract Factory Method 1.
        /// </summary>
        private static void AbstractFactoryExample()
        {
            Console.WriteLine("Start - Calling AbstractFactory Example 1 ...");
            AssignComputerToEmployee();
            DoYouWantToExit(1);
            Console.WriteLine("End - Calling AbstractFactory Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Abstract Factory Method 2.
        /// </summary>
        private static void AssignComputerToEmployee()
        {
            Console.WriteLine("Which type of Employee ? ");
            Console.WriteLine("0:Developer, 1:HR, 2:Manager ");
            var employeeType = Convert.ToInt32(Console.ReadLine());
            IComputer computer = employeeType switch
            {
                0 => new DellHighEndLaptop(),
                1 => new DellHighEndDesktop(),
                2 => new AppleHighEndLaptop(),
                _ => new DellMidRangeDesktop(),
            };
            Console.WriteLine("Brand: " + computer.Brand().GetBrand()
                + " Processor: " + computer.Processor().GetProcessor()
                + " System Type: " + computer.SystemType().GetSystemType());
        }

        /// <summary>
        /// Factory Method 1.
        /// </summary>
        private static void FactoryExample()
        {
            Console.WriteLine("Start - Calling Factory Example 1 ...");
            PurchaseProductsOnline();
            DoYouWantToExit(0);
            Console.WriteLine("End - Calling Factory Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Factory Method 2.
        /// </summary>
        private static void PurchaseProductsOnline()
        {
            var commodities = new Commodities();
            Console.WriteLine("Which payment mode would you prefer? ");
            Console.WriteLine("0 : Credit Card, 1: Debit Card, 2: Google Pay");
            Console.WriteLine(commodities.ProductPurchased(Convert.ToInt32(Console.ReadLine().Trim())));
            Console.WriteLine("Which commodity would you like to purchase? ");
            Console.WriteLine("Commodities currently available: Blood, Cotton Gold, Silk...");
            var commodity = Console.ReadLine();
            Console.WriteLine(commodities.Initialize(commodity).Replace("stuff", commodity));
        }

        /// <summary>
        /// Common Method.
        /// </summary>
        /// <param name="calledFrom">int.</param>
        private static void DoYouWantToExit(int calledFrom)
        {
            Console.WriteLine("Do you want to continue (Y / N )? ");
            var message = Console.ReadLine();

            if (message.Trim().ToLower().Contains('y'))
            {
                switch (calledFrom)
                {
                    case 0:
                        PurchaseProductsOnline();
                        break;
                    case 1:
                        AssignComputerToEmployee();
                        break;
                    default:
                        PurchaseProductsOnline();
                        break;
                }

                DoYouWantToExit(calledFrom);
            }
            else
            {
                Console.WriteLine("Thank you !!!");
            }
        }
    }
}