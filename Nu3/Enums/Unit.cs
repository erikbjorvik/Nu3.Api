using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nu3.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Unit
    {
        Ml,
        Cl,
        Dl,
        L,
        Mg,
        G,
        Hg,
        Kg
    }
}