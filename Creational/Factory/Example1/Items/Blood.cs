// <copyright file="Blood.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Items
{
    /// <summary>
    /// A Blood type of commodity.
    /// </summary>
  public class Blood : Commodities
    {
        /// <summary>
        /// Starting Delivery for Blood.
        /// </summary>
        /// <returns>string.</returns>
        public override string StartDelivery()
        {
            return this.Initialize("Blood");
        }
    }
}
