namespace Adapter.Converters
{
    internal class PdfConverter : IConvert
    {
        public string Convert(string toBeConverted)
        {
            return "Converting " + toBeConverted + " to PDF Format";
        }
    }
}
