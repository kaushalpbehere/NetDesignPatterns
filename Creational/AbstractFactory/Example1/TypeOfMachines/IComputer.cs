// <copyright file="IComputer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.Brands;
    using Creational.AbstractFactory.Example1.Processor;
    using Creational.AbstractFactory.Example1.SystemType;

    /// <summary>
    /// Computer Type.
    /// </summary>
    public interface IComputer
    {
        /// <summary>
        /// Processor for Computer.
        /// </summary>
        /// <returns>string.</returns>
        IProcessor Processor();

        /// <summary>
        /// Brand for Computer.
        /// </summary>
        /// <returns>string.</returns>
        IBrand Brand();

        /// <summary>
        /// System Type for Computer.
        /// </summary>
        /// <returns>string.</returns>
        ISystemType SystemType();
    }
}