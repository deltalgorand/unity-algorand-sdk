using System;
using AlgoSdk.Crypto;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace AlgoSdk
{
    public interface ITransactionHeader
    {
        /// <summary>
        /// Paid by the sender to the FeeSink to prevent denial-of-service. The minimum fee on Algorand is currently 1000 microAlgos.
        /// </summary>
        MicroAlgos Fee { get; set; }

        /// <summary>
        /// The first round for when the transaction is valid. If the transaction is sent prior to this round it will be rejected by the network.
        /// </summary>
        ulong FirstValidRound { get; set; }

        /// <summary>
        /// The hash of the genesis block of the network for which the transaction is valid.
        /// </summary>
        GenesisHash GenesisHash { get; set; }

        /// <summary>
        /// The ending round for which the transaction is valid. After this round, the transaction will be rejected by the network.
        /// </summary>
        ulong LastValidRound { get; set; }

        /// <summary>
        /// The address of the account that pays the fee and amount.
        /// </summary>
        Address Sender { get; set; }

        /// <summary>
        /// Specifies the type of transaction. This value is automatically generated using any of the developer tools.
        /// </summary>
        TransactionType TransactionType { get; }

        /// <summary>
        /// The human-readable string that identifies the network for the transaction. The genesis ID is found in the genesis block.
        /// </summary>
        FixedString32Bytes GenesisId { get; set; }

        /// <summary>
        /// The group specifies that the transaction is part of a group and, if so, specifies the hash of the transaction group. See <see cref="TransactionGroup"/>.
        /// </summary>
        TransactionId Group { get; set; }

        /// <summary>
        /// A lease enforces mutual exclusion of transactions. If this field is nonzero, then once the transaction is confirmed, it acquires the lease identified by the (Sender, Lease) pair of the transaction until the LastValid round passes. While this transaction possesses the lease, no other transaction specifying this lease can be confirmed. A lease is often used in the context of Algorand Smart Contracts to prevent replay attacks.
        /// </summary>
        TransactionId Lease { get; set; }

        /// <summary>
        /// Any data up to 1000 bytes.
        /// </summary>
        byte[] Note { get; set; }

        /// <summary>
        /// Specifies the authorized address. This address will be used to authorize all future transactions.
        /// </summary>
        Address RekeyTo { get; set; }
    }

    public partial struct Transaction : ITransactionHeader
    {
        /// <inheritdoc />
        [AlgoApiField("fee", "fee")]
        public MicroAlgos Fee
        {
            get => header.Fee;
            set => header.Fee = value;
        }

        /// <inheritdoc />
        [AlgoApiField("first-valid", "fv")]
        public ulong FirstValidRound
        {
            get => header.FirstValidRound;
            set => header.FirstValidRound = value;
        }

        /// <inheritdoc />
        [AlgoApiField("genesis-hash", "gh")]
        public GenesisHash GenesisHash
        {
            get => header.GenesisHash;
            set => header.GenesisHash = value;
        }

        /// <inheritdoc />
        [AlgoApiField("last-valid", "lv")]
        public ulong LastValidRound
        {
            get => header.LastValidRound;
            set => header.LastValidRound = value;
        }

        /// <inheritdoc />
        [AlgoApiField("sender", "snd")]
        public Address Sender
        {
            get => header.Sender;
            set => header.Sender = value;
        }

        /// <inheritdoc />
        [AlgoApiField("tx-type", "type")]
        public TransactionType TransactionType
        {
            get => header.TransactionType;
            set => header.TransactionType = value;
        }

        /// <inheritdoc />
        [AlgoApiField("genesis-id", "gen")]
        public FixedString32Bytes GenesisId
        {
            get => header.GenesisId;
            set => header.GenesisId = value;
        }

        /// <inheritdoc />
        [AlgoApiField("grp", "grp")]
        public TransactionId Group
        {
            get => header.Group;
            set => header.Group = value;
        }

        /// <inheritdoc />
        [AlgoApiField("lx", "lx")]
        public TransactionId Lease
        {
            get => header.Lease;
            set => header.Lease = value;
        }

        /// <inheritdoc />
        [AlgoApiField("group", null, readOnly: true)]
        public Sha512_256_Hash GroupHash
        {
            get => header.Group;
            set => header.Group = value;
        }

        /// <inheritdoc />
        [AlgoApiField("lease", null, readOnly: true)]
        public Sha512_256_Hash LeaseHash
        {
            get => header.Lease;
            set => header.Lease = value;
        }

        /// <inheritdoc />
        [AlgoApiField("note", "note")]
        public byte[] Note
        {
            get => header.Note;
            set => header.Note = value;
        }

        /// <inheritdoc />
        [AlgoApiField("rekey-to", "rekey")]
        public Address RekeyTo
        {
            get => header.RekeyTo;
            set => header.RekeyTo = value;
        }

        /// <inheritdoc />
        [AlgoApiField("id", null, readOnly: true)]
        public TransactionId Id
        {
            get => header.Id;
            set => header.Id = value;
        }

        /// <inheritdoc />
        [AlgoApiField("auth-addr", null, readOnly: true)]
        public Address AuthAddress
        {
            get => header.AuthAddress;
            set => header.AuthAddress = value;
        }

        /// <inheritdoc />
        [AlgoApiField("close-rewards", null, readOnly: true)]
        public ulong CloseRewards
        {
            get => header.CloseRewards;
            set => header.CloseRewards = value;
        }

        /// <inheritdoc />
        [AlgoApiField("closing-amount", null, readOnly: true)]
        public ulong ClosingAmount
        {
            get => header.ClosingAmount;
            set => header.ClosingAmount = value;
        }

        /// <inheritdoc />
        [AlgoApiField("confirmed-round", null, readOnly: true)]
        public ulong ConfirmedRound
        {
            get => header.ConfirmedRound;
            set => header.ConfirmedRound = value;
        }

        /// <inheritdoc />
        [AlgoApiField("created-application-index", null, readOnly: true)]
        public ulong CreatedApplicationIndex
        {
            get => header.CreatedApplicationIndex;
            set => header.CreatedApplicationIndex = value;
        }

        /// <inheritdoc />
        [AlgoApiField("created-asset-index", null, readOnly: true)]
        public ulong CreatedAssetIndex
        {
            get => header.CreatedAssetIndex;
            set => header.CreatedAssetIndex = value;
        }

        /// <inheritdoc />
        [AlgoApiField("intra-round-offset", null, readOnly: true)]
        public ulong IntraRoundOffset
        {
            get => header.IntraRoundOffset;
            set => header.IntraRoundOffset = value;
        }

        /// <inheritdoc />
        [AlgoApiField("global-state-delta", null, readOnly: true)]
        public EvalDeltaKeyValue[] GlobalStateDelta
        {
            get => header.GlobalStateDelta;
            set => header.GlobalStateDelta = value;
        }

        /// <inheritdoc />
        [AlgoApiField("local-state-delta", null, readOnly: true)]
        public AccountStateDelta[] LocalStateDelta
        {
            get => header.LocalStateDelta;
            set => header.LocalStateDelta = value;
        }

        /// <inheritdoc />
        [AlgoApiField("receiver-rewards", null, readOnly: true)]
        public ulong ReceiverRewards
        {
            get => header.ReceiverRewards;
            set => header.ReceiverRewards = value;
        }

        /// <inheritdoc />
        [AlgoApiField("round-time", null, readOnly: true)]
        public ulong RoundTime
        {
            get => header.RoundTime;
            set => header.RoundTime = value;
        }

        /// <inheritdoc />
        [AlgoApiField("sender-rewards", null, readOnly: true)]
        public ulong SenderRewards
        {
            get => header.SenderRewards;
            set => header.SenderRewards = value;
        }

        /// <inheritdoc />
        [AlgoApiField("inner-txns", null, readOnly: true)]
        public Transaction[] InnerTxns
        {
            get => header.InnerTxns;
            set => header.InnerTxns = value;
        }
    }

    /// <summary>
    /// Contains parameters used in all transaction types.
    /// </summary>
    /// <remarks>
    /// For the most part, this is used internally in the sdk and shouldn't be used directly.
    /// </remarks>
    [Serializable]
    public struct TransactionHeader
        : IEquatable<TransactionHeader>
        , ITransactionHeader
    {
        [SerializeField, Tooltip("Paid by the sender to the FeeSink to prevent denial-of-service. The minimum fee on Algorand is currently 1000 microAlgos.")]
        MicroAlgos fee;

        [SerializeField, Tooltip("The first round for when the transaction is valid. If the transaction is sent prior to this round it will be rejected by the network.")]
        ulong firstValidRound;

        [SerializeField, Tooltip("The hash of the genesis block of the network for which the transaction is valid.")]
        GenesisHash genesisHash;

        [SerializeField, Tooltip("The ending round for which the transaction is valid. After this round, the transaction will be rejected by the network.")]
        ulong lastValidRound;

        [SerializeField, Tooltip("The address of the account that pays the fee and amount.")]
        Address sender;

        [SerializeField, Tooltip("Specifies the type of transaction. This value is automatically generated using any of the developer tools.")]
        TransactionType transactionType;

        [SerializeField, Tooltip("The human-readable string that identifies the network for the transaction. The genesis ID is found in the genesis block.")]
        FixedString32Bytes genesisId;

        [SerializeField, Tooltip("The group specifies that the transaction is part of a group and, if so, specifies the hash of the transaction group.")]
        TransactionId group;

        [SerializeField, Tooltip("A lease enforces mutual exclusion of transactions. If this field is nonzero, then once the transaction is confirmed, it acquires the lease identified by the (Sender, Lease) pair of the transaction until the LastValid round passes. While this transaction possesses the lease, no other transaction specifying this lease can be confirmed. A lease is often used in the context of Algorand Smart Contracts to prevent replay attacks.")]
        TransactionId lease;

        [SerializeField, Tooltip("Any data up to 1000 bytes.")]
        byte[] note;

        [SerializeField, Tooltip("Specifies the authorized address. This address will be used to authorize all future transactions.")]
        Address rekeyTo;

        /// <inheritdoc />
        public MicroAlgos Fee
        {
            get => fee;
            set => fee = value;
        }

        /// <inheritdoc />
        public ulong FirstValidRound
        {
            get => firstValidRound;
            set => firstValidRound = value;
        }

        /// <inheritdoc />
        public GenesisHash GenesisHash
        {
            get => genesisHash;
            set => genesisHash = value;
        }

        /// <inheritdoc />
        public ulong LastValidRound
        {
            get => lastValidRound;
            set => lastValidRound = value;
        }

        /// <inheritdoc />
        public Address Sender
        {
            get => sender;
            set => sender = value;
        }

        /// <inheritdoc />
        public TransactionType TransactionType
        {
            get => transactionType;
            set => transactionType = value;
        }

        /// <inheritdoc />
        public FixedString32Bytes GenesisId
        {
            get => genesisId;
            set => genesisId = value;
        }

        /// <inheritdoc />
        public TransactionId Group
        {
            get => group;
            set => group = value;
        }

        /// <inheritdoc />
        public TransactionId Lease
        {
            get => lease;
            set => lease = value;
        }

        /// <inheritdoc />
        public byte[] Note
        {
            get => note;
            set => note = value;
        }

        /// <inheritdoc />
        public Address RekeyTo
        {
            get => rekeyTo;
            set => rekeyTo = value;
        }

        /// <inheritdoc />
        public TransactionId Id { get; set; }

        /// <inheritdoc />
        public Address AuthAddress { get; set; }

        /// <inheritdoc />
        public ulong CloseRewards { get; set; }

        /// <inheritdoc />
        public ulong ClosingAmount { get; set; }

        /// <inheritdoc />
        public ulong ConfirmedRound { get; set; }

        /// <inheritdoc />
        public ulong CreatedApplicationIndex { get; set; }

        /// <inheritdoc />
        public ulong CreatedAssetIndex { get; set; }

        /// <inheritdoc />
        public ulong IntraRoundOffset { get; set; }

        /// <inheritdoc />
        public EvalDeltaKeyValue[] GlobalStateDelta { get; set; }

        /// <inheritdoc />
        public AccountStateDelta[] LocalStateDelta { get; set; }

        /// <inheritdoc />
        public ulong ReceiverRewards { get; set; }

        /// <inheritdoc />
        public ulong RoundTime { get; set; }

        /// <inheritdoc />
        public ulong SenderRewards { get; set; }

        /// <inheritdoc />
        public OnCompletion OnCompletion { get; set; }

        /// <inheritdoc />
        public Transaction[] InnerTxns { get; set; }

        public TransactionHeader(
            Address sender,
            TransactionType transactionType,
            TransactionParams transactionParams
        )
        {
            fee = math.max(transactionParams.Fee, transactionParams.MinFee);
            firstValidRound = transactionParams.FirstValidRound;
            genesisHash = transactionParams.GenesisHash;
            lastValidRound = transactionParams.LastValidRound;
            this.sender = sender;
            this.transactionType = transactionType;

            genesisId = transactionParams.GenesisId;
            group = default;
            lease = default;
            note = default;
            rekeyTo = default;

            Id = default;
            AuthAddress = default;
            CloseRewards = default;
            ClosingAmount = default;
            ConfirmedRound = default;
            CreatedApplicationIndex = default;
            CreatedAssetIndex = default;
            IntraRoundOffset = default;
            GlobalStateDelta = default;
            LocalStateDelta = default;
            ReceiverRewards = default;
            RoundTime = default;
            SenderRewards = default;
            OnCompletion = default;
            InnerTxns = default;
        }

        public bool Equals(TransactionHeader other)
        {
            return Fee == other.Fee
                && FirstValidRound == other.FirstValidRound
                && GenesisHash.Equals(other.GenesisHash)
                && LastValidRound == other.LastValidRound
                && Sender == other.Sender
                && TransactionType == other.TransactionType
                && GenesisId == other.GenesisId
                && Group.Equals(other.Group)
                && Lease.Equals(other.Lease)
                && string.Equals(Note, other.Note)
                && RekeyTo == other.RekeyTo
                ;
        }

        public override bool Equals(object obj)
        {
            if (obj is TransactionHeader other)
                return Equals(other);
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + Fee.GetHashCode();
                hash = hash * 31 + FirstValidRound.GetHashCode();
                return hash;
            }
        }
    }
}
