// <copyright file="Singleton.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Singleton
{
    /// <summary>
    /// To instantiate and use Singleton example.
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// Object of the class.
        /// </summary>
        private static Singleton instance;

        /// <summary>
        /// A counter to check the number of times this class is initialized adn called.
        /// </summary>
        private int counter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Singleton"/> class.
        /// This initialize or retrieves the singleton object.
        /// </summary>
        private Singleton()
        {
            this.counter = 1;
        }

        /// <summary>
        /// A static method to create instance of an object.
        /// </summary>
        /// <returns>Singleton type object.</returns>
        public static Singleton CreateInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }

        /// <summary>
        /// To call this method is to increment the counter.
        /// </summary>
        public void IncrementOnCall()
        {
            this.counter++;
        }

        /// <summary>
        /// Gets the current value of the counter.
        /// </summary>
        /// <returns>int.</returns>
        public int GetCounter()
        {
            return this.counter;
        }
    }
}