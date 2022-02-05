// <copyright file="ExampleGenerator.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Abstractions;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Resolvers;
using Newtonsoft.Json.Serialization;
using RealGoodApps.OpenApiExampleAnnotations.Attributes;
using RealGoodApps.OpenApiExampleAnnotations.Constructors;

namespace RealGoodApps.OpenApiExampleAnnotations
{
    public sealed class ExampleGenerator<TResponse> : OpenApiExample<ExampleGenerator<TResponse>>
    {
        public override IOpenApiExample<ExampleGenerator<TResponse>> Build(NamingStrategy namingStrategy = null)
        {
            var example = CreateExample(
                typeof(TResponse),
                null,
                null);

            this.Examples.Add(OpenApiExampleResolver.Resolve(
                "default",
                example ?? new Dictionary<string, string>(),
                namingStrategy));
            return this;
        }

        private static object Default(Type forType)
        {
            var methodInfo = typeof(ExampleGenerator<TResponse>)
                .GetMethod(nameof(DefaultInternal), BindingFlags.Static | BindingFlags.NonPublic);

            if (methodInfo == null)
            {
                throw new InvalidOperationException("The DefaultInternal() method can not be found.");
            }

            var genericMethod = methodInfo.MakeGenericMethod(forType);
            return genericMethod.Invoke(null, Array.Empty<object>());
        }

        private static T DefaultInternal<T>()
        {
            return default;
        }

        private static object CreateExample(
            Type forType,
            object exampleKey,
            object exampleValue)
        {
            var typeClassification = TypeClassifier.CheckTypeClassification(forType);

            switch (typeClassification.Enum)
            {
                case TypeClassifier.TypeClassificationEnum.List:
                    var listItemType = typeClassification.ValueType?.RawType;

                    if (listItemType == null)
                    {
                        throw new InvalidOperationException("List item type is undefined.");
                    }

                    return new List<object> { CreateExample(listItemType, null, exampleValue) };
                case TypeClassifier.TypeClassificationEnum.Dictionary:
                    var keyType = typeClassification.KeyType?.RawType;
                    var valueType = typeClassification.ValueType?.RawType;

                    if (keyType == null || valueType == null)
                    {
                        throw new InvalidOperationException("Key or value type is undefined.");
                    }

                    var generatedExampleKey = CreateExample(keyType, null, exampleKey);
                    var generatedExampleValue = CreateExample(valueType, null, exampleValue);

                    if (generatedExampleKey == null)
                    {
                        throw new InvalidOperationException("Key example must not be null.");
                    }

                    return new Dictionary<object, object>
                    {
                        { generatedExampleKey, generatedExampleValue },
                    };
                case TypeClassifier.TypeClassificationEnum.String:
                    return ExampleGeneratorConstructor.ConstructString(exampleValue);
                case TypeClassifier.TypeClassificationEnum.Bool:
                    return ExampleGeneratorConstructor.ConstructBool(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Byte:
                    return ExampleGeneratorConstructor.ConstructByte(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.SByte:
                    return ExampleGeneratorConstructor.ConstructSByte(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Char:
                    return ExampleGeneratorConstructor.ConstructChar(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Decimal:
                    return ExampleGeneratorConstructor.ConstructDecimal(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Double:
                    return ExampleGeneratorConstructor.ConstructDouble(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Float:
                    return ExampleGeneratorConstructor.ConstructFloat(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Int:
                    return ExampleGeneratorConstructor.ConstructInt(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.UInt:
                    return ExampleGeneratorConstructor.ConstructUInt(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Long:
                    return ExampleGeneratorConstructor.ConstructLong(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.ULong:
                    return ExampleGeneratorConstructor.ConstructULong(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Short:
                    return ExampleGeneratorConstructor.ConstructShort(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.UShort:
                    return ExampleGeneratorConstructor.ConstructUShort(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Guid:
                    return ExampleGeneratorConstructor.ConstructGuid(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.DateTime:
                    return ExampleGeneratorConstructor.ConstructDateTime(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.DateTimeOffset:
                    return ExampleGeneratorConstructor.ConstructDateTimeOffset(exampleValue, typeClassification.IsNullable);
                case TypeClassifier.TypeClassificationEnum.Uri:
                    return ExampleGeneratorConstructor.ConstructUri(exampleValue);
                case TypeClassifier.TypeClassificationEnum.Struct:
                case TypeClassifier.TypeClassificationEnum.Class:
                    var publicProperties = forType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                    var generated = new Dictionary<object, object>();

                    foreach (var publicProperty in publicProperties)
                    {
                        var exampleAttribute = publicProperty.GetCustomAttribute<Example>();

                        generated[publicProperty.Name] = CreateExample(
                            publicProperty.PropertyType,
                            exampleAttribute?.Key,
                            exampleAttribute?.Value);
                    }

                    return generated;
            }

            return Default(forType);
        }
    }
}
