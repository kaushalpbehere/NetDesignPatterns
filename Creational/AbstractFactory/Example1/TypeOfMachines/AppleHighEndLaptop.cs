// <copyright file="AppleHighEndLaptop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.SystemType;

    /// <summary>
    /// A high end Apple Laptop.
    /// </summary>
    public class AppleHighEndLaptop : ComputerBaseFactory
    {
        /// <summary>
        /// Overrides the system type as Laptop.
        /// </summary>
        /// <returns>string.</returns>
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
