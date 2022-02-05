// <copyright file="ExampleGeneratorConstructor.UInt.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructUInt(
            object example,
            bool isNullable)
        {
            object @default = (uint)0;

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

                if (exampleType != typeof(uint))
                {
                    return Convert.ToUInt32(example);
                }

                var exampleAsUInt = (uint)example;
                return exampleAsUInt;
            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
