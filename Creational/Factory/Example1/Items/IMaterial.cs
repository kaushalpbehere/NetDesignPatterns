// <copyright file="IMaterial.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Items
{
    /// <summary>
    /// An abstract for Materials.
    /// </summary>
    public interface IMaterial
    {
        /// <summary>
        /// Initializing the Material.
        /// </summary>
        /// <param name="type">string of type of material to be initialized for transport.</param>
        /// <returns>string.</returns>
        string Initialize(string type);

        /// <summary>
        /// Starting for delivery.
        /// </summary>
        /// <returns>string.</returns>
        string StartDelivery();
    }
}
