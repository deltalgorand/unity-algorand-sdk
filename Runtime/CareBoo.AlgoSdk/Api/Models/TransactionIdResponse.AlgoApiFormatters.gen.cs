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
    
    
    public partial struct TransactionIdResponse
    {
        
        private static bool @__generated__IsValid = TransactionIdResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TransactionIdResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.TransactionIdResponse>(false).Assign("txId", "txId", (AlgoSdk.TransactionIdResponse x) => x.TxId, (ref AlgoSdk.TransactionIdResponse x, AlgoSdk.TransactionId value) => x.TxId = value, false));
            return true;
        }
    }
}
