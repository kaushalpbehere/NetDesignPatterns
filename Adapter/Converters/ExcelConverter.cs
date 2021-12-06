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
