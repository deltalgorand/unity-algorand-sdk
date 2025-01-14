using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct BalancesResponse
        : IEquatable<BalancesResponse>
        , IPaginatedIndexerResponse<MiniAssetHolding>
    {
        [AlgoApiField("balances", null)]
        public MiniAssetHolding[] Balances { get; set; }

        [AlgoApiField("current-round", null)]
        public ulong CurrentRound { get; set; }

        [AlgoApiField("next-token", null)]
        public FixedString128Bytes NextToken { get; set; }

        MiniAssetHolding[] IPaginatedIndexerResponse<MiniAssetHolding>.Results
        {
            get => Balances;
            set => Balances = value;
        }

        public bool Equals(BalancesResponse other)
        {
            return ArrayComparer.Equals(Balances, other.Balances)
                && CurrentRound.Equals(other.CurrentRound)
                && NextToken.Equals(other.NextToken)
                ;
        }
    }
}
