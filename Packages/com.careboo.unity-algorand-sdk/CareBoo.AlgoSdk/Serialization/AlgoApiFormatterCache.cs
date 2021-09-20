using System;
using System.Collections.Generic;
using AlgoSdk.Crypto;
using AlgoSdk.Formatters;
using Unity.Collections;

namespace AlgoSdk
{
    public static class AlgoApiFormatterCache<T>
    {
        public static readonly IAlgoApiFormatter<T> Formatter;

        static AlgoApiFormatterCache()
        {
            Formatter = AlgoApiFormatterLookup.GetFormatter<T>();
            if (Formatter == null)
                throw new NotImplementedException($"Formatter for type {typeof(T)} could not be found...");
        }
    }

    public partial class AlgoApiFormatterLookup
    {
        public const string EnsureLookupMethodName = nameof(EnsureLookupInitialized);
        public const string LookupFieldName = nameof(lookup);
        public const string InitLookupMethodName = nameof(InitLookup);
        public const string AddFormatterMethodName = nameof(AddFormatter);

        static Dictionary<Type, object> lookup;

        static void InitLookup()
        {
            lookup = new Dictionary<Type, object>();
            AddFormatter<ulong>(new UInt64Formatter());
            AddFormatter<bool>(new BoolFormatter());
            AddFormatter<string>(new StringFormatter());
            AddFormatter<Sha512_256_Hash>(ByteArrayFormatter<Sha512_256_Hash>.Instance);
            AddFormatter<byte[]>(new ByteArrayFormatter());
            AddFormatter<FixedString32Bytes>(new FixedStringFormatter<FixedString32Bytes>());
            AddFormatter<FixedString64Bytes>(new FixedStringFormatter<FixedString64Bytes>());
            AddFormatter<FixedString128Bytes>(new FixedStringFormatter<FixedString128Bytes>());
            AddFormatter<FixedString512Bytes>(new FixedStringFormatter<FixedString512Bytes>());
            AddFormatter<FixedString4096Bytes>(new FixedStringFormatter<FixedString4096Bytes>());
        }

        static void AddFormatter(Type t, object formatter)
        {
            if (lookup.ContainsKey(t))
                return;
            lookup.Add(t, formatter);
        }

        static void AddFormatter<T>(IAlgoApiFormatter<T> formatter)
        {
            var type = typeof(T);
            AddFormatter(type, formatter);
        }

        public static IAlgoApiFormatter<T> GetFormatter<T>()
        {
            if (lookup == null)
                EnsureLookupInitialized();

            var type = typeof(T);
            if (lookup.TryGetValue(typeof(T), out var formatter))
            {
            }
            else if (type.IsArray)
            {
                formatter = Activator.CreateInstance(typeof(ArrayFormatter<>).MakeGenericType(type.GetElementType()));
            }
            else if (type.IsGenericType && lookup.TryGetValue(type.GetGenericTypeDefinition(), out var openFormatterTypeObj))
            {
                var openFormatterType = (Type)openFormatterTypeObj;
                var genericFormatterType = openFormatterType.MakeGenericType(type.GenericTypeArguments);
                formatter = Activator.CreateInstance(genericFormatterType);
            }
            if (formatter is IAlgoApiFormatter<T> algoApiFormatter)
                return algoApiFormatter;
            throw new InvalidCastException($"formatter of type {formatter.GetType()} cannot be cast to {typeof(IAlgoApiFormatter<T>)}...");
        }
    }
}