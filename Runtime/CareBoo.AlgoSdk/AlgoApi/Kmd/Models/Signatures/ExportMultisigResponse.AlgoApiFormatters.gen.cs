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
    
    
    public partial struct ExportMultisigResponse
    {
        
        private static bool @__generated__IsValid = ExportMultisigResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ExportMultisigResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ExportMultisigResponse>().Assign("error", null, (AlgoSdk.ExportMultisigResponse x) => x.Error, (ref AlgoSdk.ExportMultisigResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.ExportMultisigResponse x) => x.Message, (ref AlgoSdk.ExportMultisigResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false).Assign("multisig_version", null, (AlgoSdk.ExportMultisigResponse x) => x.MultisigVersion, (ref AlgoSdk.ExportMultisigResponse x, System.Byte value) => x.MultisigVersion = value, false).Assign("pks", null, (AlgoSdk.ExportMultisigResponse x) => x.Pks, (ref AlgoSdk.ExportMultisigResponse x, AlgoSdk.Crypto.Ed25519.PublicKey[] value) => x.Pks = value, AlgoSdk.ArrayComparer<AlgoSdk.Crypto.Ed25519.PublicKey>.Instance, false).Assign("threshold", null, (AlgoSdk.ExportMultisigResponse x) => x.Threshold, (ref AlgoSdk.ExportMultisigResponse x, System.Byte value) => x.Threshold = value, false));
            return true;
        }
    }
}
