using Adapter.Converters;

namespace Adapter
{
    public class DecisionMaker
    {
        IConvert convert;

        public string StartConversion(string ConvertFrom, string ConvertTo)
        {
            convert = ConvertTo switch
            {
                ".pdf" => new PdfConverter(),
                ".doc" or ".docx" => new WordConverter(),
                ".xls" or ".xlsx" => new ExcelConverter(),
                _ => new TextConverter(),
            };
            return convert.Convert(ConvertFrom);
        }
    }
}