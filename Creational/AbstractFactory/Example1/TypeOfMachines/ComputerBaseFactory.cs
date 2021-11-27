// <copyright file="ComputerBaseFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.Brands;
    using Creational.AbstractFactory.Example1.Processor;
    using Creational.AbstractFactory.Example1.SystemType;

    /// <summary>
    /// A ComputerBase Factory returning HighEnd Apple.
    /// </summary>
    public class ComputerBaseFactory : IComputer
    {
        /// <summary>
        /// Returns MAC.
        /// </summary>
        /// <returns>string.</returns>
        public virtual IBrand Brand() => new MAC();

        /// <summary>
        /// A M3 Processor.
        /// </summary>
        /// <returns>string.</returns>
        public virtual IProcessor Processor() => new M3();

        /// <summary>
        /// A Desktop.
        /// </summary>
        /// <returns>string.</returns>
        public virtual ISystemType SystemType() => new Desktop();
    }
}
