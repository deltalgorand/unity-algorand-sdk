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
    
    
    public partial struct ExportMasterKeyResponse
    {
        
        private static bool @__generated__IsValid = ExportMasterKeyResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ExportMasterKeyResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ExportMasterKeyResponse>(false).Assign("master_derivation_key", null, (AlgoSdk.ExportMasterKeyResponse x) => x.MasterDerivationKey, (ref AlgoSdk.ExportMasterKeyResponse x, AlgoSdk.PrivateKey value) => x.MasterDerivationKey = value, false).Assign("error", null, (AlgoSdk.ExportMasterKeyResponse x) => x.Error, (ref AlgoSdk.ExportMasterKeyResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.ExportMasterKeyResponse x) => x.Message, (ref AlgoSdk.ExportMasterKeyResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false));
            return true;
        }
    }
}
