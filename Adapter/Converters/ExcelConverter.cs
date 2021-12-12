// <copyright file="ExcelConverter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Adapter.Converters
{
    internal class ExcelConverter : IConvert
    {
        public string Convert(string toBeConverted)
        {
            return "Converting " + toBeConverted + " to Excel Format";
        }
    }
}
