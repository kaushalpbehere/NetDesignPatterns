namespace DesignPatternsConsoleApp
{
    using System;

    using Builder.Example1;
    using Builder.Example1.Builder;

    using Creational.AbstractFactory.Example1.TypeOfMachines;
    using Creational.Factory.Example1;

    using Prototype.Example1;

    using Singleton;

    /// <summary>
    /// This class contains all design patterns implementations for object creation strategy.
    /// </summary>
    public static class ObjectCreation
    {
        /// <summary>
        /// An example for Singleton.
        /// </summary>
        public static void SingletonExample()
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

            Console.WriteLine("End - Calling Singleton Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Prototype Example.
        /// </summary>
        public static void PrototypeExample()
        {
            Console.WriteLine("Start - Calling Prototype Example 1 ...");

            var r1 = new Reactangle(2, 3);
            var r2 = (Reactangle)r1.Clone();
            Console.WriteLine(" r1:X - " + r1.X + " r1:Y - " + r1.Y + " r2:X - " + r2.X + " r2:Y - " + r2.Y);

            var c1 = new Circle(2);
            var c2 = (Circle)c1.Clone();
            Console.WriteLine(" c1:X - " + c1.X + " c1:Y - " + c1.Y + " c2:X - " + c2.X + " c2:Y - " + c2.Y);

            Console.WriteLine("End - Calling Prototype Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Builder Method 1.
        /// </summary>
        public static void BuilderExample()
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

            Console.WriteLine("End - Calling Builder Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Abstract Factory Method 1.
        /// </summary>
        public static void AbstractFactoryExample()
        {
            Console.WriteLine("Start - Calling AbstractFactory Example 1 ...");
            AssignComputerToEmployee();
            Console.WriteLine("End - Calling AbstractFactory Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Abstract Factory Method 2.
        /// </summary>
        public static void AssignComputerToEmployee()
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
        public static void FactoryExample()
        {
            Console.WriteLine("Start - Calling Factory Example 1 ...");
            PurchaseProductsOnline();
            Console.WriteLine("End - Calling Factory Example 1 ...");
            Console.ReadLine();
        }

        /// <summary>
        /// Factory Method 2.
        /// </summary>
        public static void PurchaseProductsOnline()
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
    }
}