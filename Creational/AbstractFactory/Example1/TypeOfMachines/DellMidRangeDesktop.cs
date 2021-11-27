// <copyright file="DellMidRangeDesktop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.Processor;

    /// <summary>
    /// A mid range desktop.
    /// </summary>
    public class DellMidRangeDesktop : DellHighEndDesktop
    {
        /// <summary>
        /// A I5 Processor.
        /// </summary>
        /// <returns>IProcessor.</returns>
        public override IProcessor Processor() => new I5();
    }
}
