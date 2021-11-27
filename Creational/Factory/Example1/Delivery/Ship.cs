// <copyright file="Ship.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Delivery
{
    /// <summary>
    /// Transport By Ship.
    /// </summary>
  public class Ship : ITransport
    {
        /// <summary>
        /// Ship Transport.
        /// </summary>
        /// <returns>string.</returns>
        public string Deliver() => "Ship will deliver your stuff.";
    }
}
