// <copyright file="Truck.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Delivery
{
    /// <summary>
    /// Transport by Truck.
    /// </summary>
    public class Truck : ITransport
    {
        /// <summary>
        /// Transport by Truck.
        /// </summary>
        /// <returns>string.</returns>
        public string Deliver() => "Truck will deliver your stuff.";
    }
}
