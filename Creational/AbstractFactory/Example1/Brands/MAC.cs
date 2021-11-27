// <copyright file="MAC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Creational.AbstractFactory.Example1.Brands
{
    /// <summary>
    /// A MAC type of IBrand.
    /// </summary>
    public class MAC : IBrand
    {
        /// <summary>
        /// Returns a MAC Brand.
        /// </summary>
        /// <returns>string.</returns>
        public string GetBrand() => "Using Apple.";
    }
}
