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
    
    
    public partial struct RenewWalletHandleTokenResponse
    {
        
        private static bool @__generated__IsValid = RenewWalletHandleTokenResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.RenewWalletHandleTokenResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.RenewWalletHandleTokenResponse>(false).Assign("error", null, (AlgoSdk.RenewWalletHandleTokenResponse x) => x.Error, (ref AlgoSdk.RenewWalletHandleTokenResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.RenewWalletHandleTokenResponse x) => x.Message, (ref AlgoSdk.RenewWalletHandleTokenResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false).Assign("wallet_handle", null, (AlgoSdk.RenewWalletHandleTokenResponse x) => x.WalletHandle, (ref AlgoSdk.RenewWalletHandleTokenResponse x, AlgoSdk.WalletHandle value) => x.WalletHandle = value, false));
            return true;
        }
    }
}
