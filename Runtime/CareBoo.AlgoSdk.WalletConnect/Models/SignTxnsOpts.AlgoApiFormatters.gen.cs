//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk.WalletConnect
{
    
    
    public partial struct SignTxnsOpts
    {
        
        private static bool @__generated__IsValid = SignTxnsOpts.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.WalletConnect.SignTxnsOpts>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.WalletConnect.SignTxnsOpts>(false).Assign("message", (AlgoSdk.WalletConnect.SignTxnsOpts x) => x.Message, (ref AlgoSdk.WalletConnect.SignTxnsOpts x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance));
            return true;
        }
    }
}
