// <copyright file="I3.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.Processor
{
    /// <summary>
    /// I3 Processor.
    /// </summary>
  public class I3 : IProcessor
    {
        /// <summary>
        /// I3 type of processor.
        /// </summary>
        /// <returns>string.</returns>
        public string GetProcessor() => "Using i3 Processor";
    }
}
