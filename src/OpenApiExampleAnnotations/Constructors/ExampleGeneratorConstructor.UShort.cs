// <copyright file="ExampleGeneratorConstructor.UShort.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructUShort(
            object example,
            bool isNullable)
        {
            object @default = (ushort)0;

            if (isNullable)
            {
                @default = null;
            }

            if (example == null)
            {
                return @default;
            }

            try
            {
                var exampleType = example.GetType();

                if (exampleType != typeof(ushort))
                {
                    return Convert.ToUInt16(example);
                }

                var exampleAsUShort = (ushort)example;
                return exampleAsUShort;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
