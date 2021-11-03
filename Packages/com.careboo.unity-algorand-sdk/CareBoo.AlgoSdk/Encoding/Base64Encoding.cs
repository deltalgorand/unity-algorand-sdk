using AlgoSdk.LowLevel;
using Unity.Collections;
using Unity.Mathematics;

namespace AlgoSdk
{
    public static class Base64Encoding
    {
        public static void CopyToBase64<TBytes, T>(this TBytes bytes, ref T s)
            where TBytes : struct, IArray<byte>
            where T : struct, IUTF8Bytes, INativeList<byte>
        {
            s.CopyFrom(System.Convert.ToBase64String(bytes.ToArray()));
        }

        public static void CopyFromBase64<TByteArray, T>(ref this TByteArray bytes, T s, int maxLength = int.MaxValue)
            where TByteArray : struct, IArray<byte>
            where T : struct, IUTF8Bytes, INativeList<byte>
        {
            var managedString = s.ToString();
            var byteArr = System.Convert.FromBase64String(managedString);
            var length = math.min(maxLength, byteArr.Length);
            for (var i = 0; i < length; i++)
                bytes[i] = byteArr[i];
        }

        public static void Utf8ToBase64<T, U>(ref this T src, ref U tar)
            where T : unmanaged, IUTF8Bytes, INativeList<byte>
            where U : unmanaged, IUTF8Bytes, INativeList<byte>
        {
            tar.Clear();
            var bytes = new byte[src.Length];
            for (var i = 0; i < src.Length; i++)
                bytes[i] = src[i];
            tar.CopyFrom(System.Convert.ToBase64String(bytes));
        }

        public static void Base64ToUtf8<T, U>(ref this T src, ref U tar)
            where T : unmanaged, IUTF8Bytes, INativeList<byte>
            where U : unmanaged, IUTF8Bytes, INativeList<byte>
        {
            tar.Clear();
            var bytes = System.Convert.FromBase64String(src.ConvertToString());
            tar.Length = bytes.Length;
            for (var i = 0; i < bytes.Length; i++)
                tar[i] = bytes[i];
        }
    }
}
