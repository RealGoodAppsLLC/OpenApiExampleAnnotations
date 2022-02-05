// <copyright file="ExampleGeneratorConstructor.ULong.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructULong(
            object example,
            bool isNullable)
        {
            object @default = (ulong)0;

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

                if (exampleType != typeof(ulong))
                {
                    return Convert.ToUInt64(example);
                }

                var exampleAsULong = (ulong)example;
                return exampleAsULong;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
