// <copyright file="I7.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.Processor
{
    /// <summary>
    /// A type of processor.
    /// </summary>
    public class I7 : IProcessor
    {
        /// <summary>
        /// Returns an I7 type of processor.
        /// </summary>
        /// <returns>string.</returns>
        public string GetProcessor() => "Using i7 Processor";
    }
}
