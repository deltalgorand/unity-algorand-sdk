using System;
using static AlgoSdk.Crypto.sodium;
using Unity.Collections.LowLevel.Unsafe;

namespace AlgoSdk.Crypto
{
    public unsafe static class Random
    {
#if (!UNITY_WEBGL || UNITY_EDITOR)
        static Random()
        {
            sodium_init();
        }
#endif

        public static T Bytes<T>() where T : unmanaged
        {
            var size = UnsafeUtility.SizeOf<T>();
            T result = default;
            randombytes_buf(&result, (UIntPtr)size);
            return result;
        }
    }
}