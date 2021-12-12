// <copyright file="House.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Builder.Example1.Builder
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A House class.
    /// </summary>
    public class House
    {
#pragma warning disable SA1000 // Keywords should be spaced correctly
        private readonly List<string> houseComponents = new();
#pragma warning restore SA1000 // Keywords should be spaced correctly

        /// <summary>
        /// Add method to add multiple steps while building.
        /// </summary>
        /// <param name="component">Component Name to be added.</param>
        public void Add(string component)
        {
            this.houseComponents.Add(component);
        }

        /// <summary>
        /// Build method which prints the steps performed while building.
        /// </summary>
        public void Build()
        {
            foreach (var house in this.houseComponents)
            {
                Console.WriteLine(house);
            }
        }
    }
}