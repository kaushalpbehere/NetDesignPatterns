// <copyright file="Commodities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.Factory.Example1
{
    using Creational.Factory.Example1.Delivery;
    using Creational.Factory.Example1.Items;
    using Creational.Factory.Example1.Payment;

    /// <summary>
    /// A commodity which initializes specific type of commodity.
    /// </summary>
    public class Commodities : IMaterial, IPayMode
    {
        /// <summary>
        /// Initializes commodity.
        /// </summary>
        /// <param name="type">Type of commodity.</param>
        /// <returns>string.</returns>
        public string Initialize(string type)
        {
            ITransport transport = type switch
            {
                "silver" or "Silver" or "gold" or "Gold" => new Ship(),
                "cotton" or "Cotton" => new Truck(),
                "Blood" or "blood" => new Helicopter(),
                "Silk" or "silk" => new Airplane(),
                _ => new Ship(),
            };
            return transport.Deliver();
        }

        /// <summary>
        /// Initiating payment.
        /// </summary>
        /// <param name="mode">Type of payment.</param>
        /// <returns>IPayment.</returns>
        public IPayment InitiatePayment(int mode)
        {
            IPayment payment = mode switch
            {
                0 => new CreditCard(),
                1 => new DebitCard(),
                2 => new GooglePay(),
                _ => new GooglePay(),
            };
            return payment;
        }

        /// <summary>
        /// Starting delivery.
        /// </summary>
        /// <returns>string.</returns>
        public virtual string StartDelivery()
        {
            return "Default provider";
        }

        /// <summary>
        /// Product being purchased.
        /// </summary>
        /// <param name="payMode">Type of payment.</param>
        /// <returns>string.</returns>
        public string ProductPurchased(int payMode)
        {
            var payment = this.InitiatePayment(payMode);

            return payment.Pay();
        }
    }
}
