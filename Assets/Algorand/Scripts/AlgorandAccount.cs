using AlgoSdk;
using AlgoSdk.Crypto;
using UnityEngine;

[CreateAssetMenu(fileName = "NewAccount", menuName = "Algorand/Create Account")]
public class AlgorandAccount : ScriptableObject
{
    [SerializeField]
    string passPhrase;

    PrivateKey privateKey => Mnemonic.FromString(passPhrase).ToPrivateKey();

    public Address Address => privateKey.ToPublicKey();

    public Ed25519.KeyPair GetKeyPair()
    {
        return privateKey.ToKeyPair();
    }

    [ContextMenu(nameof(Randomize))]
    public void Randomize()
    {
        passPhrase = privateKey.ToMnemonic().ToString();
    }
}
