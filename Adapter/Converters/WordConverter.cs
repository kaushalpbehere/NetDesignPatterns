// <copyright file="WordConverter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Adapter.Converters
{
    internal class WordConverter : IConvert
    {
        public string Convert(string toBeConverted)
        {
            return "Converting " + toBeConverted + " to Word Format";
        }
    }
}
