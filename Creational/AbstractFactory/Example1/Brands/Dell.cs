// <copyright file="Dell.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.Brands
{
    /// <summary>
    /// A Dell brand.
    /// </summary>
    public class Dell : IBrand
    {
        /// <summary>
        /// A Dell brand.
        /// </summary>
        /// <returns>string.</returns>
        public string GetBrand() => "Using Dell.";
    }
}
