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
    
    
    public partial struct AccountResponse
    {
        
        private static bool @__generated__IsValid = AccountResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AccountResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AccountResponse>(false).Assign("account", null, (AlgoSdk.AccountResponse x) => x.Account, (ref AlgoSdk.AccountResponse x, AlgoSdk.AccountInfo value) => x.Account = value, false).Assign("current-round", null, (AlgoSdk.AccountResponse x) => x.CurrentRound, (ref AlgoSdk.AccountResponse x, System.UInt64 value) => x.CurrentRound = value, false));
            return true;
        }
    }
}
