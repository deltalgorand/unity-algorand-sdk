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
    
    
    public partial struct TransactionSignature
    {
        
        private static bool @__generated__IsValid = TransactionSignature.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TransactionSignature>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.TransactionSignature>(false).Assign("logicsig", (AlgoSdk.TransactionSignature x) => x.LogicSig, (ref AlgoSdk.TransactionSignature x, AlgoSdk.LogicSig value) => x.LogicSig = value).Assign("multisig", (AlgoSdk.TransactionSignature x) => x.Multisig, (ref AlgoSdk.TransactionSignature x, AlgoSdk.MultisigSig value) => x.Multisig = value).Assign("sig", (AlgoSdk.TransactionSignature x) => x.Sig, (ref AlgoSdk.TransactionSignature x, AlgoSdk.Sig value) => x.Sig = value));
            return true;
        }
    }
}
