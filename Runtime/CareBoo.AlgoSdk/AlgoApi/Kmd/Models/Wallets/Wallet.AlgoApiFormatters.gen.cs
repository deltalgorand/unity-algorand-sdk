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
    
    
    public partial struct Wallet
    {
        
        private static bool @__generated__IsValid = Wallet.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.Wallet>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.Wallet>().Assign("driver_name", null, (AlgoSdk.Wallet x) => x.DriverName, (ref AlgoSdk.Wallet x, Unity.Collections.FixedString64Bytes value) => x.DriverName = value, false).Assign("driver_version", null, (AlgoSdk.Wallet x) => x.DriverVersion, (ref AlgoSdk.Wallet x, System.UInt32 value) => x.DriverVersion = value, false).Assign("id", null, (AlgoSdk.Wallet x) => x.Id, (ref AlgoSdk.Wallet x, Unity.Collections.FixedString128Bytes value) => x.Id = value, false).Assign("mnemonic_ux", null, (AlgoSdk.Wallet x) => x.MnemonicUx, (ref AlgoSdk.Wallet x, AlgoSdk.Optional<System.Boolean> value) => x.MnemonicUx = value, false).Assign("name", null, (AlgoSdk.Wallet x) => x.Name, (ref AlgoSdk.Wallet x, Unity.Collections.FixedString64Bytes value) => x.Name = value, false).Assign("supported_txs", null, (AlgoSdk.Wallet x) => x.SupportedTransactions, (ref AlgoSdk.Wallet x, AlgoSdk.TransactionType[] value) => x.SupportedTransactions = value, AlgoSdk.ArrayComparer<AlgoSdk.TransactionType, AlgoSdk.ByteEnumComparer<AlgoSdk.TransactionType>>.Instance, false));
            return true;
        }
    }
}
