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
    
    
    public partial struct RenewWalletHandleTokenResponse
    {
        
        private static bool @__generated__IsValid = RenewWalletHandleTokenResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Kmd.RenewWalletHandleTokenResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Kmd.RenewWalletHandleTokenResponse>(false).Assign("error", (AlgoSdk.Kmd.RenewWalletHandleTokenResponse x) => x.Error, (ref AlgoSdk.Kmd.RenewWalletHandleTokenResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value).Assign("message", (AlgoSdk.Kmd.RenewWalletHandleTokenResponse x) => x.Message, (ref AlgoSdk.Kmd.RenewWalletHandleTokenResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance).Assign("wallet_handle", (AlgoSdk.Kmd.RenewWalletHandleTokenResponse x) => x.WalletHandle, (ref AlgoSdk.Kmd.RenewWalletHandleTokenResponse x, AlgoSdk.Kmd.WalletHandle value) => x.WalletHandle = value));
            return true;
        }
    }
}
