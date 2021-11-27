// <copyright file="DellMidRangeLaptop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.Processor;

    /// <summary>
    /// Dell Computer Type of Computer.
    /// </summary>
    public class DellMidRangeLaptop : DellHighEndLaptop
    {
        /// <summary>
        /// I5 type of Processor.
        /// </summary>
        /// <returns>string.</returns>
        public override IProcessor Processor() => new I5();
    }
}
