// <copyright file="ExampleGeneratorConstructor.Long.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructLong(
            object example,
            bool isNullable)
        {
            object @default = (long)0;

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

                if (exampleType != typeof(long))
                {
                    return Convert.ToInt64(example);
                }

                var exampleAsLong = (long)example;
                return exampleAsLong;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
