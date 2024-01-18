using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace S.Environments.Objects
{
    [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public enum ProcessEnvironment
    {
        Development,
        Testing,
        Production
    }
}