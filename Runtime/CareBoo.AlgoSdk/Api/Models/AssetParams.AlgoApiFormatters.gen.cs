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
    
    
    public partial struct AssetParams
    {
        
        private static bool @__generated__IsValid = AssetParams.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AssetParams>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AssetParams>(false).Assign("clawback", "c", (AlgoSdk.AssetParams x) => x.Clawback, (ref AlgoSdk.AssetParams x, AlgoSdk.Address value) => x.Clawback = value, false).Assign("creator", null, (AlgoSdk.AssetParams x) => x.Creator, (ref AlgoSdk.AssetParams x, AlgoSdk.Address value) => x.Creator = value, false).Assign("decimals", "dc", (AlgoSdk.AssetParams x) => x.Decimals, (ref AlgoSdk.AssetParams x, System.UInt32 value) => x.Decimals = value, false).Assign("default-frozen", "df", (AlgoSdk.AssetParams x) => x.DefaultFrozen, (ref AlgoSdk.AssetParams x, System.Boolean value) => x.DefaultFrozen = value, false).Assign("freeze", "f", (AlgoSdk.AssetParams x) => x.Freeze, (ref AlgoSdk.AssetParams x, AlgoSdk.Address value) => x.Freeze = value, false).Assign("manager", "m", (AlgoSdk.AssetParams x) => x.Manager, (ref AlgoSdk.AssetParams x, AlgoSdk.Address value) => x.Manager = value, false).Assign("metadata-hash", "am", (AlgoSdk.AssetParams x) => x.MetadataHash, (ref AlgoSdk.AssetParams x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.MetadataHash = value, false).Assign("name", "an", (AlgoSdk.AssetParams x) => x.Name, (ref AlgoSdk.AssetParams x, Unity.Collections.FixedString64Bytes value) => x.Name = value, false).Assign("reserve", "r", (AlgoSdk.AssetParams x) => x.Reserve, (ref AlgoSdk.AssetParams x, AlgoSdk.Address value) => x.Reserve = value, false).Assign("total", "t", (AlgoSdk.AssetParams x) => x.Total, (ref AlgoSdk.AssetParams x, System.UInt64 value) => x.Total = value, false).Assign("unit-name", "un", (AlgoSdk.AssetParams x) => x.UnitName, (ref AlgoSdk.AssetParams x, Unity.Collections.FixedString32Bytes value) => x.UnitName = value, false).Assign("url", "au", (AlgoSdk.AssetParams x) => x.Url, (ref AlgoSdk.AssetParams x, Unity.Collections.FixedString128Bytes value) => x.Url = value, false).Assign("name-b64", null, (AlgoSdk.AssetParams x) => x.NameBase64, (ref AlgoSdk.AssetParams x, Unity.Collections.FixedString64Bytes value) => x.NameBase64 = value, false).Assign("unit-name-b64", null, (AlgoSdk.AssetParams x) => x.UnitNameBase64, (ref AlgoSdk.AssetParams x, Unity.Collections.FixedString32Bytes value) => x.UnitNameBase64 = value, false).Assign("url-b64", null, (AlgoSdk.AssetParams x) => x.UrlBase64, (ref AlgoSdk.AssetParams x, Unity.Collections.FixedString128Bytes value) => x.UrlBase64 = value, false));
            return true;
        }
    }
}
