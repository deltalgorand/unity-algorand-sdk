//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk.Kmd
{
    
    
    public partial struct ExportMasterKeyResponse
    {
        
        private static bool @__generated__IsValid = ExportMasterKeyResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Kmd.ExportMasterKeyResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Kmd.ExportMasterKeyResponse>(false).Assign("master_derivation_key", (AlgoSdk.Kmd.ExportMasterKeyResponse x) => x.MasterDerivationKey, (ref AlgoSdk.Kmd.ExportMasterKeyResponse x, AlgoSdk.PrivateKey value) => x.MasterDerivationKey = value).Assign("error", (AlgoSdk.Kmd.ExportMasterKeyResponse x) => x.Error, (ref AlgoSdk.Kmd.ExportMasterKeyResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value).Assign("message", (AlgoSdk.Kmd.ExportMasterKeyResponse x) => x.Message, (ref AlgoSdk.Kmd.ExportMasterKeyResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance));
            return true;
        }
    }
}