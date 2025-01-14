using System;
using Unity.Collections;
using UnityEngine;

namespace AlgoSdk
{
    public interface IBlockTransaction : IAppliedSignedTxn<AppliedSignedTxn>
    {
        Optional<bool> HasGenesisId { get; set; }
        Optional<bool> HasGenesisHash { get; set; }
    }

    /// <summary>
    /// A transaction found in a <see cref="BlockResponse"/> from <see cref="IAlgodClient.GetBlock"/>.
    /// </summary>
    /// <remarks>
    /// This is a <c>SignedTxnInBlock</c> from the algorand go project.
    /// </remarks>
    [AlgoApiObject]
    [Serializable]
    public partial struct BlockTransaction
        : IEquatable<BlockTransaction>
        , IBlockTransaction
    {
        [SerializeField]
        AppliedSignedTxn txn;

        [SerializeField]
        Optional<bool> hasGenesisId;

        [SerializeField]
        Optional<bool> hasGenesisHash;

        /// <inheritdoc />
        [AlgoApiField("sig", "sig")]
        public Sig Sig
        {
            get => txn.Sig;
            set => txn.Sig = value;
        }

        /// <inheritdoc />
        [AlgoApiField("msig", "msig")]
        public Multisig Msig
        {
            get => txn.Msig;
            set => txn.Msig = value;
        }

        /// <inheritdoc />
        [AlgoApiField("lsig", "lsig")]
        public LogicSig Lsig
        {
            get => txn.Lsig;
            set => txn.Lsig = value;
        }

        /// <inheritdoc />
        [AlgoApiField("txn", "txn")]
        public Transaction Txn
        {
            get => txn.Txn;
            set => txn.Txn = value;
        }

        /// <inheritdoc />
        [AlgoApiField("sgnr", "sgnr")]
        public Address AuthAddr
        {
            get => txn.AuthAddr;
            set => txn.AuthAddr = value;
        }

        /// <inheritdoc />
        [AlgoApiField("ca", "ca")]
        public MicroAlgos ClosingAmount
        {
            get => txn.ClosingAmount;
            set => txn.ClosingAmount = value;
        }

        /// <inheritdoc />
        [AlgoApiField("aca", "aca")]
        public ulong AssetClosingAmount
        {
            get => txn.AssetClosingAmount;
            set => txn.AssetClosingAmount = value;
        }

        /// <inheritdoc />
        [AlgoApiField("rr", "rr")]
        public MicroAlgos ReceiverRewards
        {
            get => txn.ReceiverRewards;
            set => txn.ReceiverRewards = value;
        }

        /// <inheritdoc />
        [AlgoApiField("rs", "rs")]
        public MicroAlgos SenderRewards
        {
            get => txn.SenderRewards;
            set => txn.SenderRewards = value;
        }

        /// <inheritdoc />
        [AlgoApiField("rc", "rc")]
        public MicroAlgos CloseRewards
        {
            get => txn.CloseRewards;
            set => txn.CloseRewards = value;
        }

        /// <inheritdoc />
        [AlgoApiField("dt", "dt")]
        public AppEvalDelta<AppliedSignedTxn> EvalDelta
        {
            get => txn.EvalDelta;
            set => txn.EvalDelta = value;
        }

        /// <inheritdoc />
        [AlgoApiField("caid", "caid")]
        public AssetIndex ConfigAsset
        {
            get => txn.ConfigAsset;
            set => txn.ConfigAsset = value;
        }

        /// <inheritdoc />
        [AlgoApiField("apid", "apid")]
        public AppIndex ApplicationId
        {
            get => txn.ApplicationId;
            set => txn.ApplicationId = value;
        }

        /// <inheritdoc />
        [AlgoApiField("hgi", "hgi")]
        public Optional<bool> HasGenesisId { get; set; }

        /// <inheritdoc />
        [AlgoApiField("hgh", "hgh")]
        public Optional<bool> HasGenesisHash { get; set; }

        /// <inheritdoc />
        public TransactionSignature Signature
        {
            get => txn.Signature;
            set => txn.Signature = value;
        }

        /// <inheritdoc />
        public TransactionHeader Header
        {
            get => txn.Header;
            set => txn.Header = value;
        }

        /// <inheritdoc />
        public PaymentTxn.Params PaymentParams
        {
            get => txn.PaymentParams;
            set => txn.PaymentParams = value;
        }

        /// <inheritdoc />
        public AssetConfigTxn.Params AssetConfigParams
        {
            get => txn.AssetConfigParams;
            set => txn.AssetConfigParams = value;
        }

        /// <inheritdoc />
        public AssetTransferTxn.Params AssetTransferParams
        {
            get => txn.AssetTransferParams;
            set => txn.AssetTransferParams = value;
        }

        /// <inheritdoc />
        public AssetFreezeTxn.Params AssetFreezeParams
        {
            get => txn.AssetFreezeParams;
            set => txn.AssetFreezeParams = value;
        }

        /// <inheritdoc />
        public AppCallTxn.Params AppCallParams
        {
            get => txn.AppCallParams;
            set => txn.AppCallParams = value;
        }

        /// <inheritdoc />
        public KeyRegTxn.Params KeyRegParams
        {
            get => txn.KeyRegParams;
            set => txn.KeyRegParams = value;
        }

        /// <inheritdoc />
        public MicroAlgos Fee
        {
            get => txn.Fee;
            set => txn.Fee = value;
        }

        /// <inheritdoc />
        public ulong FirstValidRound
        {
            get => txn.FirstValidRound;
            set => txn.FirstValidRound = value;
        }

        /// <inheritdoc />
        public GenesisHash GenesisHash
        {
            get => txn.GenesisHash;
            set => txn.GenesisHash = value;
        }

        /// <inheritdoc />
        public ulong LastValidRound
        {
            get => txn.LastValidRound;
            set => txn.LastValidRound = value;
        }

        /// <inheritdoc />
        public Address Sender
        {
            get => txn.Sender;
            set => txn.Sender = value;
        }

        /// <inheritdoc />
        public TransactionType TransactionType
        {
            get => txn.TransactionType;
            set => txn.TransactionType = value;
        }

        /// <inheritdoc />
        public FixedString32Bytes GenesisId
        {
            get => txn.GenesisId;
            set => txn.GenesisId = value;
        }

        /// <inheritdoc />
        public TransactionId Group
        {
            get => txn.Group;
            set => txn.Group = value;
        }

        /// <inheritdoc />
        public TransactionId Lease
        {
            get => txn.Lease;
            set => txn.Lease = value;
        }

        /// <inheritdoc />
        public byte[] Note
        {
            get => txn.Note;
            set => txn.Note = value;
        }

        /// <inheritdoc />
        public Address RekeyTo
        {
            get => txn.RekeyTo;
            set => txn.RekeyTo = value;
        }

        /// <inheritdoc />
        public AppStateDelta GlobalDelta
        {
            get => txn.GlobalDelta;
            set => txn.GlobalDelta = value;
        }

        /// <inheritdoc />
        public AccountStateDelta[] LocalDeltas
        {
            get => txn.LocalDeltas;
            set => txn.LocalDeltas = value;
        }

        /// <inheritdoc />
        public string[] Logs
        {
            get => txn.Logs;
            set => txn.Logs = value;
        }

        /// <inheritdoc />
        public AppliedSignedTxn[] InnerTxns
        {
            get => txn.InnerTxns;
            set => txn.InnerTxns = value;
        }

        public bool Equals(BlockTransaction other)
        {
            return txn.Equals(other.txn);
        }

        public bool Equals(AppliedSignedTxn other)
        {
            return txn.Equals(other);
        }

        public static implicit operator Transaction(BlockTransaction blockTxn)
        {
            return blockTxn.txn.Txn;
        }

        [Obsolete("Use Msig instead")]
        public Multisig Multisig
        {
            get => txn.Msig;
            set => txn.Msig = value;
        }

        [Obsolete("Use Lsig instead")]
        public LogicSig LogicSig
        {
            get => txn.Lsig;
            set => txn.Lsig = value;
        }

        [Obsolete("Use HasGenesisId instead.")]
        public Optional<bool> Hgi { get; set; }

        [Obsolete("Use Txn instead.")]
        public Transaction Transaction
        {
            get => txn.Txn;
            set => txn.Txn = value;
        }

        [Obsolete("Replaced with SenderRewards")]
        public ulong Rs { get => SenderRewards; set => SenderRewards = value; }

        [Obsolete("Replaced with ReceiverRewards")]
        public ulong Rr { get => ReceiverRewards; set => ReceiverRewards = value; }
    }
}
