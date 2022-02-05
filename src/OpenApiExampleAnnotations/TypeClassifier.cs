// <copyright file="TypeClassifier.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;
using System.Linq;

namespace RealGoodApps.OpenApiExampleAnnotations
{
    internal static class TypeClassifier
    {
        internal static TypeClassification CheckTypeClassification(Type forType)
        {
            if (forType == typeof(string))
            {
                return new TypeClassification(
                    TypeClassificationEnum.String,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(Uri))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Uri,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(Guid))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Guid,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(Guid?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Guid,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(DateTime))
            {
                return new TypeClassification(
                    TypeClassificationEnum.DateTime,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(DateTime?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.DateTime,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(DateTimeOffset))
            {
                return new TypeClassification(
                    TypeClassificationEnum.DateTimeOffset,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(DateTimeOffset?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.DateTimeOffset,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(bool))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Bool,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(bool?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Bool,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(byte))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Byte,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(byte?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Byte,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(sbyte))
            {
                return new TypeClassification(
                    TypeClassificationEnum.SByte,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(sbyte?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.SByte,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(char))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Char,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(char?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Char,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(decimal))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Decimal,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(decimal?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Decimal,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(double))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Double,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(double?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Double,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(float))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Float,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(float?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Float,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(int))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Int,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(int?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Int,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(uint))
            {
                return new TypeClassification(
                    TypeClassificationEnum.UInt,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(uint?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.UInt,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(long))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Long,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(long?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Long,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(ulong))
            {
                return new TypeClassification(
                    TypeClassificationEnum.ULong,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(ulong?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.ULong,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(short))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Short,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(short?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.Short,
                    forType,
                    null,
                    null,
                    true);
            }

            if (forType == typeof(ushort))
            {
                return new TypeClassification(
                    TypeClassificationEnum.UShort,
                    forType,
                    null,
                    null,
                    false);
            }

            if (forType == typeof(ushort?))
            {
                return new TypeClassification(
                    TypeClassificationEnum.UShort,
                    forType,
                    null,
                    null,
                    true);
            }

            var genericEnumerableInterface = forType.GetInterfaces()
                .FirstOrDefault(i => i.Namespace == "System.Collections.Generic"
                                     && i.Name == "IEnumerable`1"
                                     && i.GenericTypeArguments.Length == 1);

            if (genericEnumerableInterface == null)
            {
                if (!forType.IsValueType)
                {
                    return new TypeClassification(
                        TypeClassificationEnum.Class,
                        forType,
                        null,
                        null,
                        true);
                }

                var underlyingType = Nullable.GetUnderlyingType(forType);

                return new TypeClassification(
                    TypeClassificationEnum.Struct,
                    forType,
                    null,
                    null,
                    underlyingType != null);
            }

            var genericTypeArgument = genericEnumerableInterface.GenericTypeArguments[0];

            var isKeyValuePairType = genericTypeArgument.Namespace == "System.Collections.Generic"
                                     && genericTypeArgument.Name == "KeyValuePair`2"
                                     && genericTypeArgument.GenericTypeArguments.Length == 2;

            if (!isKeyValuePairType)
            {
                // TODO: Are lists always nullable? I would assume yes.
                return new TypeClassification(
                    TypeClassificationEnum.List,
                    forType,
                    null,
                    CheckTypeClassification(genericTypeArgument),
                    true);
            }

            return new TypeClassification(
                TypeClassificationEnum.Dictionary,
                forType,
                CheckTypeClassification(genericTypeArgument.GenericTypeArguments[0]),
                CheckTypeClassification(genericTypeArgument.GenericTypeArguments[1]),
                true);
        }

        internal enum TypeClassificationEnum
        {
            None = 0,
            List,
            Dictionary,
            String,
            Guid,
            Uri,
            DateTime,
            DateTimeOffset,
            Bool,
            Byte,
            SByte,
            Char,
            Decimal,
            Double,
            Float,
            Int,
            UInt,
            Long,
            ULong,
            Short,
            UShort,
            Struct,
            Class,
        }

        internal class TypeClassification
        {
            internal TypeClassification(
                TypeClassificationEnum @enum,
                Type rawType,
                TypeClassification keyType,
                TypeClassification valueType,
                bool isNullable)
            {
                Enum = @enum;
                RawType = rawType;
                KeyType = keyType;
                ValueType = valueType;
                IsNullable = isNullable;
            }

            internal TypeClassificationEnum Enum { get; }
            internal Type RawType { get; }
            internal TypeClassification KeyType { get; }
            internal TypeClassification ValueType { get; }
            internal bool IsNullable { get; }
        }
    }
}
