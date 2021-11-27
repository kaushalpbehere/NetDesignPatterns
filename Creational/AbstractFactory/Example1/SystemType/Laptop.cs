// <copyright file="Laptop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.SystemType
{
    /// <summary>
    /// System Type of Computer.
    /// </summary>
  public class Laptop : ISystemType
    {
        /// <summary>
        /// Laptop Type of System.
        /// </summary>
        /// <returns>string.</returns>
        public string GetSystemType() => "Using Laptop.";
    }
}
