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
    
    
    public partial struct SignTxnsError
    {
        
        private static bool @__generated__IsValid = SignTxnsError.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.WalletConnect.SignTxnsError>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.WalletConnect.SignTxnsError>(false).Assign("message", null, (AlgoSdk.WalletConnect.SignTxnsError x) => x.Message, (ref AlgoSdk.WalletConnect.SignTxnsError x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false).Assign("code", null, (AlgoSdk.WalletConnect.SignTxnsError x) => x.Code, (ref AlgoSdk.WalletConnect.SignTxnsError x, System.Int32 value) => x.Code = value, false).Assign("data", null, (AlgoSdk.WalletConnect.SignTxnsError x) => x.Data, (ref AlgoSdk.WalletConnect.SignTxnsError x, AlgoSdk.AlgoApiObject value) => x.Data = value, false));
            return true;
        }
    }
}
