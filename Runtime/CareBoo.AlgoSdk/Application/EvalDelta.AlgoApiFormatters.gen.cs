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
    
    
    public partial struct EvalDelta<TTxn>
    {
        
        private static bool @__generated__IsValid = EvalDelta<TTxn>.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.EvalDelta<TTxn>>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.EvalDelta<TTxn>>(false).Assign("gd", (AlgoSdk.EvalDelta<TTxn> x) => x.GlobalDelta, (ref AlgoSdk.EvalDelta<TTxn> x, AlgoSdk.StateDelta value) => x.GlobalDelta = value).Assign("ld", (AlgoSdk.EvalDelta<TTxn> x) => x.LocalDeltas, (ref AlgoSdk.EvalDelta<TTxn> x, AlgoSdk.StateDelta[] value) => x.LocalDeltas = value, AlgoSdk.ArrayComparer<AlgoSdk.StateDelta>.Instance).Assign("lg", (AlgoSdk.EvalDelta<TTxn> x) => x.Logs, (ref AlgoSdk.EvalDelta<TTxn> x, System.String[] value) => x.Logs = value, AlgoSdk.ArrayComparer<System.String, AlgoSdk.StringComparer>.Instance).Assign("itx", (AlgoSdk.EvalDelta<TTxn> x) => x.InnerTxns, (ref AlgoSdk.EvalDelta<TTxn> x, TTxn[] value) => x.InnerTxns = value, AlgoSdk.ArrayComparer<TTxn>.Instance));
            return true;
        }
    }
}