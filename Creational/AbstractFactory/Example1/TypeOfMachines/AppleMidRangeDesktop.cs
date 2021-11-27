// <copyright file="AppleMidRangeDesktop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.TypeOfMachines
{
    using Creational.AbstractFactory.Example1.Processor;

    /// <summary>
    /// A Mind range Apple Desktop.
    /// </summary>
    public class AppleMidRangeDesktop
    {
        /// <summary>
        /// A M2 processor.
        /// </summary>
        /// <returns>IProcessor.</returns>
        public virtual IProcessor Processor()
        {
            return new M2();
        }
    }
}
