// <copyright file="IConvert.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Adapter.Converters
{
    /// <summary>
    /// IConvert Interface helps to implement a mandatory convert method.
    /// </summary>
    public interface IConvert
    {
        /// <summary>
        /// A convert method.
        /// </summary>
        /// <param name="toBeConverted">Original File Type.</param>
        /// <returns>Converted File Type.</returns>
        string Convert(string toBeConverted);
    }
}
