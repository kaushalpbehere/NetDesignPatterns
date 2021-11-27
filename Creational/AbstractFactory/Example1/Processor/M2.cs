// <copyright file="M2.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.Processor
{
    /// <summary>
    /// Processor Type of Computer.
    /// </summary>
  public class M2 : IProcessor
    {
        /// <summary>
        /// M2 Type of Processor.
        /// </summary>
        /// <returns>string.</returns>
        public string GetProcessor() => "Using M2 Processor";
    }
}
