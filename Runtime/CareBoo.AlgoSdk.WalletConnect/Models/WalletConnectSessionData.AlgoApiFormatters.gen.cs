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
    
    
    public partial struct WalletConnectSessionData
    {
        
        private static bool @__generated__IsValid = WalletConnectSessionData.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.WalletConnect.WalletConnectSessionData>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.WalletConnect.WalletConnectSessionData>(false).Assign("peerId", null, (AlgoSdk.WalletConnect.WalletConnectSessionData x) => x.PeerId, (ref AlgoSdk.WalletConnect.WalletConnectSessionData x, System.String value) => x.PeerId = value, AlgoSdk.StringComparer.Instance, false).Assign("peerMeta", null, (AlgoSdk.WalletConnect.WalletConnectSessionData x) => x.PeerMeta, (ref AlgoSdk.WalletConnect.WalletConnectSessionData x, AlgoSdk.WalletConnect.ClientMeta value) => x.PeerMeta = value, false).Assign("approved", null, (AlgoSdk.WalletConnect.WalletConnectSessionData x) => x.IsApproved, (ref AlgoSdk.WalletConnect.WalletConnectSessionData x, System.Boolean value) => x.IsApproved = value, false).Assign("chainId", null, (AlgoSdk.WalletConnect.WalletConnectSessionData x) => x.ChainId, (ref AlgoSdk.WalletConnect.WalletConnectSessionData x, System.Int32 value) => x.ChainId = value, false).Assign("accounts", null, (AlgoSdk.WalletConnect.WalletConnectSessionData x) => x.Accounts, (ref AlgoSdk.WalletConnect.WalletConnectSessionData x, AlgoSdk.Address[] value) => x.Accounts = value, AlgoSdk.ArrayComparer<AlgoSdk.Address>.Instance, false));
            return true;
        }
    }
}
