using Adapter.Converters;

namespace Adapter
{
    public class DecisionMaker
    {
        IConvert convert;

        public string StartConversion(string ConvertFrom, string ConvertTo)
        {
            switch (ConvertTo)
            {
                case ".pdf":
                    convert = new PdfConverter();
                    break;
                case ".doc":
                case ".docx":
                    convert = new WordConverter();
                    break;

                case ".xls":
                case ".xlsx":
                    convert = new ExcelConverter();
                    break;
                default:
                case ".rtf":
                case ".txt":
                    convert = new TextConverter();
                    break;


            }
            return convert.Convert(ConvertFrom);
        }
    }
}