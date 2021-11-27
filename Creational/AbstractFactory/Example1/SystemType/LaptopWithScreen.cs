// <copyright file="LaptopWithScreen.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.SystemType
{
    /// <summary>
    /// System Type of Computer.
    /// </summary>
  public class LaptopWithScreen : ISystemType
    {
        /// <summary>
        /// Laptop With Screen type of System.
        /// </summary>
        /// <returns>string.</returns>
        public string GetSystemType() => "Using Laptop with additional screen.";
    }
}