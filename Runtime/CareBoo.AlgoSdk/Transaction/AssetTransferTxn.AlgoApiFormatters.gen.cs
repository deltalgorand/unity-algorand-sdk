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
    
    
    public partial struct AssetTransferTxn
    {
        
        private static bool @__generated__IsValid = AssetTransferTxn.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AssetTransferTxn>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AssetTransferTxn>().Assign("fee", "fee", (AlgoSdk.AssetTransferTxn x) => x.Fee, (ref AlgoSdk.AssetTransferTxn x, System.UInt64 value) => x.Fee = value, false).Assign("first-valid", "fv", (AlgoSdk.AssetTransferTxn x) => x.FirstValidRound, (ref AlgoSdk.AssetTransferTxn x, System.UInt64 value) => x.FirstValidRound = value, false).Assign("genesis-hash", "gh", (AlgoSdk.AssetTransferTxn x) => x.GenesisHash, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.GenesisHash value) => x.GenesisHash = value, false).Assign("last-valid", "lv", (AlgoSdk.AssetTransferTxn x) => x.LastValidRound, (ref AlgoSdk.AssetTransferTxn x, System.UInt64 value) => x.LastValidRound = value, false).Assign("sender", "snd", (AlgoSdk.AssetTransferTxn x) => x.Sender, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.Address value) => x.Sender = value, false).Assign("tx-type", "type", (AlgoSdk.AssetTransferTxn x) => x.TransactionType, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.TransactionType value) => x.TransactionType = value, AlgoSdk.ByteEnumComparer<AlgoSdk.TransactionType>.Instance, false).Assign("genesis-id", "gen", (AlgoSdk.AssetTransferTxn x) => x.GenesisId, (ref AlgoSdk.AssetTransferTxn x, Unity.Collections.FixedString32Bytes value) => x.GenesisId = value, false).Assign("group", "grp", (AlgoSdk.AssetTransferTxn x) => x.Group, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.Group = value, false).Assign("lease", "lx", (AlgoSdk.AssetTransferTxn x) => x.Lease, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.Crypto.Sha512_256_Hash value) => x.Lease = value, false).Assign("note", "note", (AlgoSdk.AssetTransferTxn x) => x.Note, (ref AlgoSdk.AssetTransferTxn x, System.Byte[] value) => x.Note = value, AlgoSdk.ArrayComparer<byte>.Instance, false).Assign("rekey-to", "rekey", (AlgoSdk.AssetTransferTxn x) => x.RekeyTo, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.Address value) => x.RekeyTo = value, false).Assign(null, "xaid", (AlgoSdk.AssetTransferTxn x) => x.XferAsset, (ref AlgoSdk.AssetTransferTxn x, System.UInt64 value) => x.XferAsset = value, false).Assign(null, "aamt", (AlgoSdk.AssetTransferTxn x) => x.AssetAmount, (ref AlgoSdk.AssetTransferTxn x, System.UInt64 value) => x.AssetAmount = value, false).Assign(null, "asnd", (AlgoSdk.AssetTransferTxn x) => x.AssetSender, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.Address value) => x.AssetSender = value, false).Assign(null, "arcv", (AlgoSdk.AssetTransferTxn x) => x.AssetReceiver, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.Address value) => x.AssetReceiver = value, false).Assign(null, "aclose", (AlgoSdk.AssetTransferTxn x) => x.AssetCloseTo, (ref AlgoSdk.AssetTransferTxn x, AlgoSdk.Address value) => x.AssetCloseTo = value, false).Assign("close-amount", "close-amount", (AlgoSdk.AssetTransferTxn x) => x.CloseAmount, (ref AlgoSdk.AssetTransferTxn x, System.UInt64 value) => x.CloseAmount = value, false));
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.TransactionType>(new AlgoSdk.Formatters.TransactionTypeFormatter());
            return true;
        }
        
        public partial struct Params
        {
            
            private static bool @__generated__IsValid = Params.@__generated__InitializeAlgoApiFormatters();
            
            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AssetTransferTxn.Params>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AssetTransferTxn.Params>().Assign("asset-id", "xaid", (AlgoSdk.AssetTransferTxn.Params x) => x.XferAsset, (ref AlgoSdk.AssetTransferTxn.Params x, System.UInt64 value) => x.XferAsset = value, false).Assign("amount", "aamt", (AlgoSdk.AssetTransferTxn.Params x) => x.AssetAmount, (ref AlgoSdk.AssetTransferTxn.Params x, System.UInt64 value) => x.AssetAmount = value, false).Assign("sender", "asnd", (AlgoSdk.AssetTransferTxn.Params x) => x.AssetSender, (ref AlgoSdk.AssetTransferTxn.Params x, AlgoSdk.Address value) => x.AssetSender = value, false).Assign("receiver", "arcv", (AlgoSdk.AssetTransferTxn.Params x) => x.AssetReceiver, (ref AlgoSdk.AssetTransferTxn.Params x, AlgoSdk.Address value) => x.AssetReceiver = value, false).Assign("close-to", "aclose", (AlgoSdk.AssetTransferTxn.Params x) => x.AssetCloseTo, (ref AlgoSdk.AssetTransferTxn.Params x, AlgoSdk.Address value) => x.AssetCloseTo = value, false).Assign("close-amount", "close-amount", (AlgoSdk.AssetTransferTxn.Params x) => x.CloseAmount, (ref AlgoSdk.AssetTransferTxn.Params x, System.UInt64 value) => x.CloseAmount = value, false));
                return true;
            }
        }
    }
}
