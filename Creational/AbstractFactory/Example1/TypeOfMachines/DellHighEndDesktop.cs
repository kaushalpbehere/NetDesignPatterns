// <copyright file="DellHighEndDesktop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.Brands;
    using Creational.AbstractFactory.Example1.Processor;
    using Creational.AbstractFactory.Example1.SystemType;

    /// <summary>
    /// Base Computer Type of Computer.
    /// </summary>
    public class DellHighEndDesktop : ComputerBaseFactory
    {
        /// <summary>
        /// Return a DELL Brand for the Dell High End Machine.
        /// </summary>
        /// <returns>IBrand.</returns>
        public override IBrand Brand()
        {
            return new Dell();
        }

        /// <summary>
        /// A I7 processor.
        /// </summary>
        /// <returns>IProcessor.</returns>
        public override IProcessor Processor()
        {
            return new I7();
        }

        /// <summary>
        /// A system type as Desktop.
        /// </summary>
        /// <returns>ISystemType.</returns>
        public override ISystemType SystemType()
        {
            return new Desktop();
        }
    }
}