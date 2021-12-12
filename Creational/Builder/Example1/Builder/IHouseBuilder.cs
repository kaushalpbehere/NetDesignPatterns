// <copyright file="IHouseBuilder.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Builder.Example1.Builder
{
    /// <summary>
    /// A basic builder having all required step to build a house.
    /// </summary>
    public interface IHouseBuilder
    {
        /// <summary>
        /// Building foundation.
        /// </summary>
        public void BuildFoundation();

        /// <summary>
        /// Building Basic Infrastructure required for house.
        /// </summary>
        public void BuildBasicInfrastructure();

        /// <summary>
        /// Building Additional systems, i.e heating, cooling, ventilation etc.
        /// </summary>
        public void BuildAdditionalSystems();

        /// <summary>
        /// This return the final House Object which is created.
        /// </summary>
        /// <returns>A House.</returns>
        public House GetFinalOutcome();
    }
}