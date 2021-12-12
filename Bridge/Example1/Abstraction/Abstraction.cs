// <copyright file="Abstraction.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Bridge.Example1.Abstraction
{
    /// <summary>
    /// Abstraction Class for Bridge pattern.
    /// </summary>
    public class Abstraction
    {
        private Implementor implementor;

        /// <summary>
        /// Sets implementor field.
        /// </summary>
        public Implementor Implementor
        {
            set { this.implementor = value; }
        }

        /// <summary>
        /// Default Operation method.
        /// </summary>
        public virtual void Operation()
        {
            this.implementor.Operation();
        }
    }
}
