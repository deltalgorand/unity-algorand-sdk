using AlgoSdk;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAssetParams", menuName = "Algorand/Create Asset Params")]
public class AlgorandAssetParams : ScriptableObject
{
    [SerializeField]
    string assetName;

    [SerializeField]
    string unitName;

    [SerializeField]
    [Range(0, 32)]
    uint decimals;

    [SerializeField]
    ulong total;

    [SerializeField]
    AlgorandAccount manager;

    [SerializeField]
    AlgorandAccount clawback;

    [SerializeField]
    AlgorandAccount reserve;

    [SerializeField]
    AlgorandAccount freeze;

    [SerializeField]
    bool defaultFrozen;

    public ulong Index;

    public AssetParams AssetParams => new AssetParams
    {
        Name = assetName,
        UnitName = unitName,
        Decimals = decimals,
        Total = total,
        Manager = manager?.Address ?? default,
        Clawback = clawback?.Address ?? default,
        Reserve = reserve?.Address ?? default,
        Freeze = freeze?.Address ?? default,
        DefaultFrozen = defaultFrozen
    };

    public static implicit operator AssetParams(AlgorandAssetParams a)
    {
        return a.AssetParams;
    }
}
