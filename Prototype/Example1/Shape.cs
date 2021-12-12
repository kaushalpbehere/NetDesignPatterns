// <copyright file="Shape.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Prototype.Example1
{
    /// <summary>
    /// A Shape class.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// Constructor for the class.
        /// </summary>
        /// <param name="x">Length.</param>
        /// <param name="y">Breadth.</param>
        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets property to interact with x.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Gets property to interact with y.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Provision to clone the object.
        /// </summary>
        /// <returns>Shape Type Clone object.</returns>
        public abstract Shape Clone();
    }
}