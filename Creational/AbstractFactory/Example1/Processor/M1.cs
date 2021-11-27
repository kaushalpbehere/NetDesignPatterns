// <copyright file="M1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.Processor
{
    /// <summary>
    /// Processor Type of Computer.
    /// </summary>
  public class M1 : IProcessor
    {
        /// <summary>
        /// M1 Type of Processor.
        /// </summary>
        /// <returns>string.</returns>
        public string GetProcessor() => "Using M1 Processor";
    }
}
