using AlgoSdk.Crypto;
using NUnit.Framework;

public class Sha512Test
{
    [Test]
    public void Sha512IsTruncatedTo32Bytes()
    {
        var seed = AlgoSdk.Crypto.Random.Bytes<Ed25519.Seed>();
        var hash = AlgoSdk.Crypto.Sha512.Hash256Truncated(seed);
        Assert.AreEqual(32, hash.Length);
    }
}