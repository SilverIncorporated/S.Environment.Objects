namespace S.Environments.Objects;

public static class EnvironmentConstants 
{
    public static string ProcessEnvironmentVariablePrefix(ProcessEnvironment env, string productKey, string resourceName)
    {
        return EnvironmentShorthand(env) + "." + productKey + "." + resourceName;
    }  

    public static string EnvironmentSettingsStorage = "SCALE.EnvironmentSettings";

    public static string ProductKeyAssetName = "SCALE - Product Key";

    public static string ProductNameAssetName = "SCALE - Product Name";

    public static string EnvironmentAssetName = "SCALE - Environment";

    public static string EnvironmentShorthand(ProcessEnvironment env) {
        switch (env){
            case ProcessEnvironment.Production:
                return "Prod";
            case ProcessEnvironment.Testing:
                return "Test";
            default:
                return "Dev";
        }
    }
}