// <copyright file="IPayment.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Payment
{
    /// <summary>
    /// Types of Payment.
    /// </summary>
    public interface IPayment
    {
        /// <summary>
        /// Payment Method.
        /// </summary>
        /// <returns>string.</returns>
        string Pay();
    }
}
