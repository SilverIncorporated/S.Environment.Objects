using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace S.Environments.Objects;

// <summary>
// Class <c>EnvironmentSettings</c> models the settings of the given environment.
// </summary>
[DataContract]
[JsonObject(memberSerialization: MemberSerialization.OptIn)]
public class EnvironmentSettings
{
    public EnvironmentSettings(ProcessEnvironment environment, string productKey, string productName)
    {
        Environment = environment;
        ProductKey = productKey;
        ProductName = productName;
    }

    // <summary>
    // Property <c>Environment</c> represents the current runtime environment for the process.
    // </summary>
    [DataMember]
    [JsonProperty]
    public ProcessEnvironment Environment;

    // <summary>
    // Property <c>ProductKey</c> is the key that uniquely identifies the product currently running.
    // </summary>
    [DataMember]
    [JsonProperty]
    public string ProductKey;

    // <summary>
    // Property <c>Productname</c> is the name unique to the product currently running.
    // </summary>
    [DataMember]
    [JsonProperty]
    public string ProductName;

    public string ToJson() {
        return JsonConvert.SerializeObject(this);
    }
}