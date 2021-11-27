// <copyright file="Gold.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Items
{
    /// <summary>
    /// Gold Commodity.
    /// </summary>
  public class Gold : Commodities
    {
        /// <summary>
        /// Delivering Gold.
        /// </summary>
        /// <returns>string.</returns>
        public override string StartDelivery() => this.Initialize("Gold");
    }
}