// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DesignPatternsConsoleApp
{
    using System;

    /// <summary>
    /// The start of the DesignPatterns.
    /// </summary>
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Which program would you like to run? ");
            Console.WriteLine("100: Exit ");
            Console.WriteLine(" === Object Creation Patterns === ");
            Console.WriteLine("0: Factory, 1: Abstract Factory, 2: Builder, 3:Prototype, 4:Singleton");
            Console.WriteLine(" === Structural Patterns === ");
            Console.WriteLine(" 5:Adapter");
            var message = Convert.ToInt32(Console.ReadLine());
            switch (message)
            {
                case 0:
                    ObjectCreation.FactoryExample();
                    break;
                case 1:
                    ObjectCreation.AbstractFactoryExample();
                    break;
                case 2:
                    ObjectCreation.BuilderExample();
                    break;
                case 3:
                    ObjectCreation.PrototypeExample();
                    break;
                case 4:
                    ObjectCreation.SingletonExample();
                    break;
                case 5:
                    Structural.AdapterExample();
                    break;
                case 100:
                    Console.WriteLine("Thank you !!!");
                    break;
            }

            Console.WriteLine("Press any key to exit the program ...");
        }
    }
}