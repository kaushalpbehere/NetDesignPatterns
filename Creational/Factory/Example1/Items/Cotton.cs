// <copyright file="Cotton.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Items
{
    /// <summary>
    /// Cotton Commodity.
    /// </summary>
  public class Cotton : Commodities
    {
        /// <summary>
        /// Delivering Cotton.
        /// </summary>
        /// <returns>string.</returns>
        public override string StartDelivery() => this.Initialize("Cotton");
    }
}
