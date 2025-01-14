using System;
using UnityEngine;

namespace AlgoSdk
{
    /// <summary>
    /// The <see cref="StateSchema"/> object is only required for the create application call transaction. The <see cref="StateSchema"/> object must be fully populated for both the <see cref="IAppCallTxn.GlobalStateSchema"/> and <see cref="IAppCallTxn.LocalStateSchema"/> objects.
    /// </summary>
    [AlgoApiObject, Serializable]
    public partial struct StateSchema
        : IEquatable<StateSchema>
    {
        [SerializeField, Tooltip("Maximum number of integer values that may be stored in the [global || local] application key/value store. Immutable.")]
        ulong numByteSlices;

        [SerializeField, Tooltip("Maximum number of byte slices values that may be stored in the [global || local] application key/value store. Immutable.")]
        ulong numUints;

        /// <summary>
        /// Maximum number of integer values that may be stored in the [global || local] application key/value store. Immutable.
        /// </summary>
        [AlgoApiField("num-byte-slice", "nbs")]
        public ulong NumByteSlices
        {
            get => numByteSlices;
            set => numByteSlices = value;
        }

        /// <summary>
        /// Maximum number of byte slices values that may be stored in the [global || local] application key/value store. Immutable.
        /// </summary>
        [AlgoApiField("num-uint", "nui")]
        public ulong NumUints
        {
            get => numUints;
            set => numUints = value;
        }

        public bool Equals(StateSchema other)
        {
            return NumByteSlices.Equals(other.NumByteSlices)
                && NumUints.Equals(other.NumUints)
                ;
        }
    }
}
