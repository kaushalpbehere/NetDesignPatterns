// <copyright file="IPayMode.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Payment
{
    /// <summary>
    /// PaymentMode.
    /// </summary>
    public interface IPayMode
    {
        /// <summary>
        /// Payment Initiation.
        /// </summary>
        /// <param name="payMode">Type of payment.</param>
        /// <returns>IPayment.</returns>
        public IPayment InitiatePayment(int payMode);
    }
}
