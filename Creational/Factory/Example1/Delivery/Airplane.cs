// <copyright file="Airplane.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Delivery
{
    /// <summary>
    /// Airplane Type of Transport.
    /// </summary>
  public class Airplane : ITransport
    {
        /// <summary>
        /// Delivering by AirPlane.
        /// </summary>
        /// <returns>string.</returns>
        public string Deliver() => "A Airplane will deliver your stuff.";
    }
}