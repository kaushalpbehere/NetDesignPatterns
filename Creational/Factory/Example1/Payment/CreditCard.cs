// <copyright file="CreditCard.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Payment
{
    /// <summary>
    /// A Credit Card type of payment.
    /// </summary>
    public class CreditCard : IPayment
    {
        /// <summary>
        /// Payment by CreditCard.
        /// </summary>
        /// <returns>string.</returns>
        public string Pay() => "Credit Card: Payment done.";
    }
}