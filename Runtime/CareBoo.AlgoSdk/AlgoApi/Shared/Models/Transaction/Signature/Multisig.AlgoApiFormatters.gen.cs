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
    
    
    public partial struct Multisig
    {
        
        private static bool @__generated__IsValid = Multisig.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Multisig>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Multisig>().Assign("subsignature", "subsig", (AlgoSdk.Multisig x) => x.Subsigs, (ref AlgoSdk.Multisig x, AlgoSdk.Multisig.Subsig[] value) => x.Subsigs = value, AlgoSdk.ArrayComparer<AlgoSdk.Multisig.Subsig>.Instance, false).Assign("threshold", "thr", (AlgoSdk.Multisig x) => x.Threshold, (ref AlgoSdk.Multisig x, System.Byte value) => x.Threshold = value, false).Assign("version", "v", (AlgoSdk.Multisig x) => x.Version, (ref AlgoSdk.Multisig x, System.Byte value) => x.Version = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Multisig[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.Multisig>.Instance);
            return true;
        }
        
        public partial struct Subsig
        {
            
            private static bool @__generated__IsValid = Subsig.@__generated__InitializeAlgoApiFormatters();
            
            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Multisig.Subsig>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Multisig.Subsig>().Assign("public-key", "pk", (AlgoSdk.Multisig.Subsig x) => x.PublicKey, (ref AlgoSdk.Multisig.Subsig x, AlgoSdk.Crypto.Ed25519.PublicKey value) => x.PublicKey = value, false).Assign("signature", "s", (AlgoSdk.Multisig.Subsig x) => x.Sig, (ref AlgoSdk.Multisig.Subsig x, AlgoSdk.Sig value) => x.Sig = value, false));
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Multisig.Subsig[]>(AlgoSdk.Formatters.ArrayFormatter<AlgoSdk.Multisig.Subsig>.Instance);
                return true;
            }
        }
    }
}