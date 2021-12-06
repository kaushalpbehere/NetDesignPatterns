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
