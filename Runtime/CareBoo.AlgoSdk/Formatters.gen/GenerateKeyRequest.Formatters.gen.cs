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
    
    
    public partial struct GenerateKeyRequest
    {
        
        private static bool @__generated__IsValid = GenerateKeyRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Kmd.GenerateKeyRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Kmd.GenerateKeyRequest>(false).Assign("display_mnemonic", (AlgoSdk.Kmd.GenerateKeyRequest x) => x.DisplayMnemonic, (ref AlgoSdk.Kmd.GenerateKeyRequest x, AlgoSdk.Optional<System.Boolean> value) => x.DisplayMnemonic = value).Assign("wallet_handle_token", (AlgoSdk.Kmd.GenerateKeyRequest x) => x.WalletHandleToken, (ref AlgoSdk.Kmd.GenerateKeyRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value));
            return true;
        }
    }
}