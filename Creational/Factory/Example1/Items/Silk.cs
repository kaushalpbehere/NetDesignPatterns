// <copyright file="Silk.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Items
{
    /// <summary>
    /// Silk Commodity Type.
    /// </summary>
  public class Silk : Commodities
    {
        /// <summary>
        /// Delivering Silk.
        /// </summary>
        /// <returns>string.</returns>
        public override string StartDelivery() => this.Initialize("Silk");
    }
}
