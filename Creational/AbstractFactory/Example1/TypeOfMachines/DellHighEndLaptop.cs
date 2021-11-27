// <copyright file="DellHighEndLaptop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.SystemType;

    /// <summary>
    /// A High end dell laptop.
    /// </summary>
    public class DellHighEndLaptop : DellHighEndDesktop
    {
        /// <summary>
        /// A Laptop.
        /// </summary>
        /// <returns>string.</returns>
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
