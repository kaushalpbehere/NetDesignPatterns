// <copyright file="GooglePay.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Payment
{
    /// <summary>
    /// A GooglePay type of Payment.
    /// </summary>
    public class GooglePay : IPayment
    {
        /// <summary>
        /// Payment done by GooglePay.
        /// </summary>
        /// <returns>string.</returns>
        public string Pay() => "Google Pay: Payment done.";
    }
}
