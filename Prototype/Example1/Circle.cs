// <copyright file="Circle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Prototype.Example1
{
    /// <summary>
    /// A Circle Class.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// Construct a Circle object.
        /// </summary>
        /// <param name="radius"> distance.</param>
        public Circle(int radius)
            : base(radius, radius)
        {
        }

        /// <summary>
        /// Creates a shallow copy of the current.
        /// </summary>
        /// <returns>Shape Type of object.</returns>
        public override Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }
    }
}
