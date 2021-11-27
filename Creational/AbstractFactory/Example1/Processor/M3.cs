// <copyright file="M3.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.Processor
{
    /// <summary>
    /// Processor Type of Computer.
    /// </summary>
  public class M3 : IProcessor
    {
        /// <summary>
        /// M3 Type of Processor.
        /// </summary>
        /// <returns>string.</returns>
        public string GetProcessor() => "Using M3 Processor";
    }
}
