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
    
    
    public partial struct SignTransactionResponse
    {
        
        private static bool @__generated__IsValid = SignTransactionResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.SignTransactionResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.SignTransactionResponse>(false).Assign("signed_transaction", null, (AlgoSdk.SignTransactionResponse x) => x.SignedTransaction, (ref AlgoSdk.SignTransactionResponse x, System.Byte[] value) => x.SignedTransaction = value, AlgoSdk.ArrayComparer<System.Byte>.Instance, false).Assign("error", null, (AlgoSdk.SignTransactionResponse x) => x.Error, (ref AlgoSdk.SignTransactionResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.SignTransactionResponse x) => x.Message, (ref AlgoSdk.SignTransactionResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false));
            return true;
        }
    }
}
