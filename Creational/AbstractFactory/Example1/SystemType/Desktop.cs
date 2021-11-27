// <copyright file="Desktop.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.SystemType
{
    /// <summary>
    /// System Type of Computer.
    /// </summary>
  public class Desktop : ISystemType
    {
        /// <summary>
        /// Desktop Type of system.
        /// </summary>
        /// <returns>string.</returns>
        public string GetSystemType() => "Using Desktop.";
    }
}
