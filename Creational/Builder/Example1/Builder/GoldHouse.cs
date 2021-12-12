// <copyright file="GoldHouse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Builder.Example1.Builder
{
    /// <summary>
    /// A Gold House.
    /// </summary>
    public class GoldHouse
    {
#pragma warning disable SA1000 // Keywords should be spaced correctly
        private readonly House house = new();
#pragma warning restore SA1000 // Keywords should be spaced correctly

        /// <summary>
        /// Building Gold Systems.
        /// </summary>
        public void BuildGoldSystems()
        {
            this.house.Add("Building Golden Systems...");
        }

        /// <summary>
        /// Building Expensive Infrastructure.
        /// </summary>
        public void BuildExpensiveInfrastructure()
        {
            this.house.Add("Building Gold Infrastructure...");
        }

        /// <summary>
        /// Building Golden Foundation.
        /// </summary>
        public void BuildGoldFoundation()
        {
            this.house.Add("Building Gold Foundation ...");
        }

        /// <summary>
        /// Returns the final outcome.
        /// </summary>
        /// <returns>A Golden House.</returns>
        public House GetFinalOutcome()
        {
            return this.house;
        }
    }
}
