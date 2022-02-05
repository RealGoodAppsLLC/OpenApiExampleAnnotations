// <copyright file="ExampleGeneratorConstructor.Short.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructShort(
            object example,
            bool isNullable)
        {
            object @default = (short)0;

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

                if (exampleType != typeof(short))
                {
                    return Convert.ToInt16(example);
                }

                var exampleAsShort = (short)example;
                return exampleAsShort;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
