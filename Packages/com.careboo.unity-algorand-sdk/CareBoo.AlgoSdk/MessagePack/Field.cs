using System;
using System.Collections.Generic;
using MessagePack;
using Unity.Collections;

namespace AlgoSdk.MsgPack
{
    public class Field<TMessagePackObject>
        where TMessagePackObject : struct
    {
        public class Map : SortedDictionary<FixedString64Bytes, Field<TMessagePackObject>>
        {
            public Map Assign<T>(FixedString64Bytes key, FieldGetter<T> field)
                where T : IEquatable<T>
            {
                Add(key, Field<TMessagePackObject>.Assign(field));
                return this;
            }

            public Map Assign<T>(FixedString64Bytes key, FieldGetter<T> field, IEqualityComparer<T> comparer)
            {
                Add(key, Field<TMessagePackObject>.Assign(field, comparer));
                return this;
            }
        }

        public delegate bool SerializePredicate(ref TMessagePackObject messagePackObject);

        public delegate void Deserializer(
            ref TMessagePackObject messagePackObject,
            ref MessagePackReader reader,
            MessagePackSerializerOptions options);

        public delegate void Serializer(
            ref TMessagePackObject messagePackObject,
            ref MessagePackWriter writer,
            MessagePackSerializerOptions options);

        public delegate ref T FieldGetter<T>(ref TMessagePackObject messagePackObject);

        public delegate bool EqualityComparer(ref TMessagePackObject messagePackObject, ref TMessagePackObject other);

        public readonly Deserializer Deserialize;
        public readonly Serializer Serialize;
        public readonly SerializePredicate ShouldSerialize;
        public readonly EqualityComparer FieldsEqual;

        public Field(Deserializer deserialize, Serializer serialize, SerializePredicate shouldSerialize, EqualityComparer fieldsEqual)
        {
            Deserialize = deserialize;
            Serialize = serialize;
            FieldsEqual = fieldsEqual;
            ShouldSerialize = shouldSerialize;
        }

        public static Field<TMessagePackObject> Assign<T>(FieldGetter<T> field)
            where T : IEquatable<T>
        {
            bool fieldsEqual(ref TMessagePackObject messagePackObject, ref TMessagePackObject other)
            {
                return field(ref messagePackObject).Equals(field(ref other));
            }
            bool shouldSerialize(ref TMessagePackObject messagePackObject)
            {
                return !field(ref messagePackObject).Equals(default);
            }
            return Assign(field, fieldsEqual, shouldSerialize);
        }

        public static Field<TMessagePackObject> Assign<T>(FieldGetter<T> field, IEqualityComparer<T> comparer)
        {
            bool fieldsEqual(ref TMessagePackObject messagePackObject, ref TMessagePackObject other)
            {
                return comparer.Equals(field(ref messagePackObject), field(ref other));
            }
            bool shouldSerialize(ref TMessagePackObject messagePackObject)
            {
                return !comparer.Equals(field(ref messagePackObject), default);
            }
            return Assign(field, fieldsEqual, shouldSerialize);
        }

        public static Field<TMessagePackObject> Assign<T>(FieldGetter<T> field, EqualityComparer fieldsEqual, SerializePredicate shouldSerialize)
        {
            void serialize(ref TMessagePackObject messagePackObject, ref MessagePackWriter writer, MessagePackSerializerOptions options)
            {
                options.Resolver.GetFormatter<T>().Serialize(ref writer, field(ref messagePackObject), options);
            }
            void deserialize(ref TMessagePackObject messagePackObject, ref MessagePackReader reader, MessagePackSerializerOptions options)
            {
                field(ref messagePackObject) = (options.Resolver.GetFormatter<T>().Deserialize(ref reader, options));
            }
            return new Field<TMessagePackObject>(deserialize, serialize, shouldSerialize, fieldsEqual);
        }
    }
}