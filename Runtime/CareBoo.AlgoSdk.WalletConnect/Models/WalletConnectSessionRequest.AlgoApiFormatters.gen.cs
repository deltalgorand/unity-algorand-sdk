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
    
    
    public partial struct WalletConnectSessionRequest
    {
        
        private static bool @__generated__IsValid = WalletConnectSessionRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.WalletConnect.WalletConnectSessionRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.WalletConnect.WalletConnectSessionRequest>().Assign("peerId", null, (AlgoSdk.WalletConnect.WalletConnectSessionRequest x) => x.PeerId, (ref AlgoSdk.WalletConnect.WalletConnectSessionRequest x, System.String value) => x.PeerId = value, AlgoSdk.StringComparer.Instance, false).Assign("peerMeta", null, (AlgoSdk.WalletConnect.WalletConnectSessionRequest x) => x.PeerMeta, (ref AlgoSdk.WalletConnect.WalletConnectSessionRequest x, AlgoSdk.WalletConnect.ClientMeta value) => x.PeerMeta = value, false).Assign("chainId", null, (AlgoSdk.WalletConnect.WalletConnectSessionRequest x) => x.ChainId, (ref AlgoSdk.WalletConnect.WalletConnectSessionRequest x, AlgoSdk.Optional<System.Int32> value) => x.ChainId = value, false));
            return true;
        }
    }
}
