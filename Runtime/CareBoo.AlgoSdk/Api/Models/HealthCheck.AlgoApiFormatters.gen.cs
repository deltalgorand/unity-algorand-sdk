//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{
    
    
    public partial struct HealthCheck
    {
        
        private static bool @__generated__IsValid = HealthCheck.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.HealthCheck>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.HealthCheck>(false).Assign("data", "data", (AlgoSdk.HealthCheck x) => x.Data, (ref AlgoSdk.HealthCheck x, AlgoSdk.AlgoApiObject value) => x.Data = value, false).Assign("db-available", "db-available", (AlgoSdk.HealthCheck x) => x.DatabaseAvailable, (ref AlgoSdk.HealthCheck x, System.Boolean value) => x.DatabaseAvailable = value, false).Assign("errors", "errors", (AlgoSdk.HealthCheck x) => x.Errors, (ref AlgoSdk.HealthCheck x, System.String[] value) => x.Errors = value, AlgoSdk.ArrayComparer<System.String, AlgoSdk.StringComparer>.Instance, false).Assign("is-migrating", "is-migrating", (AlgoSdk.HealthCheck x) => x.IsMigrating, (ref AlgoSdk.HealthCheck x, System.Boolean value) => x.IsMigrating = value, false).Assign("message", "message", (AlgoSdk.HealthCheck x) => x.Message, (ref AlgoSdk.HealthCheck x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false).Assign("round", "round", (AlgoSdk.HealthCheck x) => x.Round, (ref AlgoSdk.HealthCheck x, System.UInt64 value) => x.Round = value, false).Assign("version", "version", (AlgoSdk.HealthCheck x) => x.Version, (ref AlgoSdk.HealthCheck x, System.String value) => x.Version = value, AlgoSdk.StringComparer.Instance, false));
            return true;
        }
    }
}
