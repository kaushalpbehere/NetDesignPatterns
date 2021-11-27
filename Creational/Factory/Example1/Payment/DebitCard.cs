// <copyright file="DebitCard.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1.Payment
{
    /// <summary>
    /// A DebitCard Payment.
    /// </summary>
  public class DebitCard : IPayment
    {
        /// <summary>
        /// Payment by DebitCard.
        /// </summary>
        /// <returns>string.</returns>
        public string Pay() => "Debit Card: Payment done.";
    }
}
