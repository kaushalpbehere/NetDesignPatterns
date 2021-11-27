// <copyright file="ITransport.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Delivery
{
    /// <summary>
    /// Transport Type.
    /// </summary>
    public interface ITransport
    {
        /// <summary>
        /// Transport Mode.
        /// </summary>
        /// <returns>string.</returns>
        string Deliver();
    }
}
