namespace Adapter.Converters
{
    internal class TextConverter : IConvert
    {
        public string Convert(string toBeConverted)
        {
            return "Converting " + toBeConverted + " to Text Format";
        }
    }
}
