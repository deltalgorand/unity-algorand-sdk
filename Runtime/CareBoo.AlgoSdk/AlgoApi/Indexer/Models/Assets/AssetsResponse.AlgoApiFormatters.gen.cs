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
    
    
    public partial struct AssetsResponse
    {
        
        private static bool @__generated__IsValid = AssetsResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AssetsResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AssetsResponse>().Assign("assets", null, (AlgoSdk.AssetsResponse x) => x.Assets, (ref AlgoSdk.AssetsResponse x, AlgoSdk.Asset[] value) => x.Assets = value, AlgoSdk.ArrayComparer<AlgoSdk.Asset>.Instance, false).Assign("current-round", null, (AlgoSdk.AssetsResponse x) => x.CurrentRound, (ref AlgoSdk.AssetsResponse x, System.UInt64 value) => x.CurrentRound = value, false).Assign("next-token", null, (AlgoSdk.AssetsResponse x) => x.NextToken, (ref AlgoSdk.AssetsResponse x, Unity.Collections.FixedString128Bytes value) => x.NextToken = value, false));
            return true;
        }
    }
}
