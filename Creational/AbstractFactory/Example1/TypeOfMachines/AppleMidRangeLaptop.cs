// <copyright file="AppleMidRangeLaptop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.Processor;

    /// <summary>
    /// A Apple mid range laptop.
    /// </summary>
    public class AppleMidRangeLaptop : AppleHighEndLaptop
    {
        /// <summary>
        /// A M2 processor.
        /// </summary>
        /// <returns>IProcessor.</returns>
        public override IProcessor Processor()
        {
            return new M2();
        }
    }
}
