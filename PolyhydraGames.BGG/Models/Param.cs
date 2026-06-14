namespace PolyhydraGames.BGG.Models
{
    public struct Param
    {
        public Param(string key, bool value)
        {
            Key = key;
            Value = value.ToString();
        }
        public Param(string key, string value)
        {
            Key = key;
            Value = value;
        }
        public Param(string key, int value)
        {
            Key = key;
            Value = value.ToString();
        }
        public string Key { get; }
        public string Value { get; }
        public string Encode() => $"?{Key}={Value}";
    }
}