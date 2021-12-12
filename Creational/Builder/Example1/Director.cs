// <copyright file="Director.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Builder.Example1
{
    using Builder;

    /// <summary>
    /// A Director to direct while building the House.
    /// </summary>
    public class Director
    {
        /// <summary>
        /// Construct a Simple House.
        /// </summary>
        /// <param name="simpleHouse">SimpleHouse Builder object.</param>
#pragma warning disable CA1822 // Mark members as static
        public void ConstructSimpleHouse(SimpleHouse simpleHouse)
#pragma warning restore CA1822 // Mark members as static
        {
            simpleHouse.BuildFoundation();
            simpleHouse.BuildBasicInfrastructure();
            simpleHouse.BuildAdditionalSystems();
        }

        /// <summary>
        /// Construct a Fancy House.
        /// </summary>
        /// <param name="fancyGlassHouse">Fancy Glass Builder object.</param>
#pragma warning disable CA1822 // Mark members as static
        public void ConstructFancyHouse(FancyGlassHouse fancyGlassHouse)
#pragma warning restore CA1822 // Mark members as static
        {
            fancyGlassHouse.BuildFoundation();
            fancyGlassHouse.BuildBasicInfrastructure();
            fancyGlassHouse.BuildAdditionalSystems();
        }

        /// <summary>
        /// Construct a more expensive gold House. (Which does not implement the standard interface.
        /// </summary>
        /// <param name="goldHouse">A goldHouse Builder object.</param>
#pragma warning disable CA1822 // Mark members as static
        public void ConstructGoldHouse(GoldHouse goldHouse)
#pragma warning restore CA1822 // Mark members as static
        {
            goldHouse.BuildGoldFoundation();
            goldHouse.BuildExpensiveInfrastructure();
            goldHouse.BuildGoldSystems();
        }
    }
}