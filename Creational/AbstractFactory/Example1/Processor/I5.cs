// <copyright file="I5.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.Processor
{
    /// <summary>
    /// I% type of Processor, compatible with Dell.
    /// </summary>
    public class I5 : IProcessor
    {
        /// <summary>
        /// Gives the type of processor being used.
        /// </summary>
        /// <returns>string.</returns>
        public string GetProcessor() => "Using i5 Processor";
    }
}
