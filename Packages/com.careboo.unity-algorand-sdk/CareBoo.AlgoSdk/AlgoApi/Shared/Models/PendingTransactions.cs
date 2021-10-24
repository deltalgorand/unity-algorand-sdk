using System;

namespace AlgoSdk
{
    /// <summary>
    /// A potentially truncated list of transactions currently in the node's transaction pool. You can compute whether or not the list is truncated if the number of elements in the <see cref="TopTransactions"/> array is fewer than <see cref="TotalTransactions"/>.
    /// </summary>
    [AlgoApiObject]
    public struct PendingTransactions
        : IEquatable<PendingTransactions>
    {
        /// <summary>
        /// An array of signed transaction objects.
        /// </summary>
        [AlgoApiField("top-transactions", "top-transactions")]
        public SignedTransaction[] TopTransactions;

        /// <summary>
        /// Total number of transactions in the pool.
        /// </summary>
        [AlgoApiField("total-transactions", "total-transactions")]
        public ulong TotalTransactions;

        public bool Equals(PendingTransactions other)
        {
            return TotalTransactions.Equals(other.TotalTransactions)
                && ArrayComparer.Equals(TopTransactions, other.TopTransactions)
                ;
        }
    }
}