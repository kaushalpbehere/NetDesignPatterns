// <copyright file="SimpleHouse.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Builder.Example1.Builder
{
    /// <summary>
    /// A Simple House.
    /// </summary>
    public class SimpleHouse : IHouseBuilder
    {
        private readonly House house = new();

        /// <summary>
        /// Builds a basic additional systems.
        /// </summary>
        public void BuildAdditionalSystems()
        {
            this.house.Add("Building Basic Additional Systems...");
        }

        /// <summary>
        /// Builds basic Infrastructure.
        /// </summary>
        public void BuildBasicInfrastructure()
        {
            this.house.Add("Building Basic Infrastructure...");
        }

        /// <summary>
        /// Builds basic foundation.
        /// </summary>
        public void BuildFoundation()
        {
            this.house.Add("Building Foundation ...");
        }

        /// <summary>
        /// Builds a simple house as final output.
        /// </summary>
        /// <returns>A Simple House.</returns>
        public House GetFinalOutcome()
        {
            return this.house;
        }
    }
}