// <copyright file="DecisionMaker.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Adapter
{
    using Adapter.Converters;

    /// <summary>
    /// A DecisionMaker takes the decision of invoking a converter at run-time based on which file type is passed.
    /// </summary>
    public class DecisionMaker
    {
        private IConvert convert;

        /// <summary>
        /// Starting the file type conversion.
        /// </summary>
        /// <param name="convertFrom">Original File Type.</param>
        /// <param name="convertTo">Desired File Type.</param>
        /// <returns>Converted File Type.</returns>
        public string StartConversion(string convertFrom, string convertTo)
        {
            this.convert = convertTo switch
            {
                ".pdf" => new PdfConverter(),
                ".doc" or ".docx" => new WordConverter(),
                ".xls" or ".xlsx" => new ExcelConverter(),
                _ => new TextConverter(),
            };
            return this.convert.Convert(convertFrom);
        }
    }
}