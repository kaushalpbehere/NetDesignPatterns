// <copyright file="Helicopter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Delivery
{
    /// <summary>
    /// Helicopter Type of Transport.
    /// </summary>
  public class Helicopter : ITransport
    {
        /// <summary>
        /// Delivering by Helicopter.
        /// </summary>
        /// <returns>string.</returns>
        public string Deliver() => "A Helicopter will deliver your stuff.";
    }
}
