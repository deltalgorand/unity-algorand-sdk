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
    
    
    public partial struct MultisigMetadata
    {
        
        private static bool @__generated__IsValid = MultisigMetadata.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.WalletConnect.MultisigMetadata>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.WalletConnect.MultisigMetadata>(false).Assign("version", (AlgoSdk.WalletConnect.MultisigMetadata x) => x.Version, (ref AlgoSdk.WalletConnect.MultisigMetadata x, System.Byte value) => x.Version = value).Assign("threshold", (AlgoSdk.WalletConnect.MultisigMetadata x) => x.Threshold, (ref AlgoSdk.WalletConnect.MultisigMetadata x, System.Byte value) => x.Threshold = value).Assign("addrs", (AlgoSdk.WalletConnect.MultisigMetadata x) => x.Addresses, (ref AlgoSdk.WalletConnect.MultisigMetadata x, AlgoSdk.Address[] value) => x.Addresses = value, AlgoSdk.ArrayComparer<AlgoSdk.Address>.Instance));
            return true;
        }
    }
}
