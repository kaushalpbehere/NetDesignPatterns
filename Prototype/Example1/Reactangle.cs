// <copyright file="Reactangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Prototype.Example1
{
    /// <summary>
    /// A Rectangle Class.
    /// </summary>
    public class Reactangle : Shape
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reactangle"/> class.
        /// A Rectangle object construction.
        /// </summary>
        /// <param name="length">Distance as length.</param>
        /// <param name="breadth">Distance as breadth.</param>
        public Reactangle(int length, int breadth)
            : base(length, breadth)
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
