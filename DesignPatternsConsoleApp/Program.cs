// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPatternsConsoleApp
{
    using System;

    using Adapter;

    using Builder.Example1;
    using Builder.Example1.Builder;

    using Creational.AbstractFactory.Example1.TypeOfMachines;
    using Creational.Factory.Example1;

    using Prototype.Example1;

    using Singleton;

    /// <summary>
    /// The start of the DesignPatterns.
    /// </summary>
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Which program would you like to run? ");
            Console.WriteLine("100: Exit ");
            Console.WriteLine(" === Creational Patterns === ");
            Console.WriteLine("0: Factory, 1: Abstract Factory, 2: Builder, 3:Prototype, 4:Singleton");
            Console.WriteLine(" === Structural Patterns === ");
            Console.WriteLine(" 5:Adapter");
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
                    BuilderExample();
                    break;
                case 3:
                    PrototypeExample();
                    break;
                case 4:
                    SingletonExample();
                    break;
                case 5:
                    AdapterExample();
                    break;
                case 100:
                    Console.WriteLine("Thank you !!!");
                    break;
            }

            Console.WriteLine("Press any key to exit the program ...");
        }

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

            DoYouWantToExit(1);
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
            var fileExtension = string.Empty;
            switch (convertFrom)
            {
                default:
                case 0:
                    fileExtension = ".txt";
                    break;
                case 1:
                    fileExtension = ".rtf";
                    break;
                case 2:
                    fileExtension = ".doc";
                    break;
                case 3:
                    fileExtension = ".docx";
                    break;
                case 4:
                    fileExtension = ".xls";
                    break;
                case 5:
                    fileExtension = ".xlsx";
                    break;
                case 6:
                    fileExtension = ".pdf";
                    break;
            }

            return fileExtension;
        }


        /// <summary>
        /// An example for Singleton.
        /// </summary>
        private static void SingletonExample()
        {
            Console.WriteLine("Start - Calling Singleton Example 1 ...");
            Console.WriteLine("Creating a new object...");

            var instance = Singleton.CreateInstance();
            Console.WriteLine(" Counter: " + instance.GetCounter());
            instance.IncrementOnCall();
            instance.IncrementOnCall();
            Console.WriteLine(" Incremented Counter: " + instance.GetCounter());

            var instance2 = Singleton.CreateInstance();
            Console.WriteLine(" Second Instance Counter: " + instance2.GetCounter());
            instance2.IncrementOnCall();
            Console.WriteLine(" Incremented Second Instance Counter: " + instance2.GetCounter());

            Console.WriteLine("This proves that the same object is returned on the second instance as well...");

            DoYouWantToExit(1);
            Console.WriteLine("End - Calling Singleton Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Prototype Example.
        /// </summary>
        private static void PrototypeExample()
        {
            Console.WriteLine("Start - Calling Prototype Example 1 ...");

            var r1 = new Reactangle(2, 3);
            var r2 = (Reactangle)r1.Clone();
            Console.WriteLine(" r1:X - " + r1.X + " r1:Y - " + r1.Y + " r2:X - " + r2.X + " r2:Y - " + r2.Y);

            var c1 = new Circle(2);
            var c2 = (Circle)c1.Clone();
            Console.WriteLine(" c1:X - " + c1.X + " c1:Y - " + c1.Y + " c2:X - " + c2.X + " c2:Y - " + c2.Y);

            DoYouWantToExit(1);
            Console.WriteLine("End - Calling Prototype Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Builder Method 1.
        /// </summary>
        private static void BuilderExample()
        {
            Console.WriteLine("Start - Calling Builder Example 1 ...");

            var director = new Director();
            var house = new House();
            Console.WriteLine("Which type of House, do you want to construct ? ");
            Console.WriteLine("0:Default, 1:Simple, 2:Fancy, 3:House with Gold. ");
            var houseType = Convert.ToInt32(Console.ReadLine());

            switch (houseType)
            {
                default:
                case 0:
                    var simpleHouse = new Builder.Example1.Builder.SimpleHouse();
                    director.ConstructSimpleHouse(simpleHouse);
                    house = simpleHouse.GetFinalOutcome();
                    break;
                case 1:
                    var fancyHouse = new Builder.Example1.Builder.FancyGlassHouse();
                    director.ConstructFancyHouse(fancyHouse);
                    house = fancyHouse.GetFinalOutcome();
                    break;
                case 2: // Gold house does not implement the same interface.
                    var goldHouse = new Builder.Example1.Builder.GoldHouse();
                    director.ConstructGoldHouse(goldHouse);
                    house = goldHouse.GetFinalOutcome();
                    break;
            }

            house.Build();

            DoYouWantToExit(1);
            Console.WriteLine("End - Calling Builder Example 1 ...");
            Console.ReadLine();
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