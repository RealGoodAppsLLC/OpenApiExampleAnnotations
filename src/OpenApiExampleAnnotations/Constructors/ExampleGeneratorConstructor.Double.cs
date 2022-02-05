// <copyright file="ExampleGeneratorConstructor.Double.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructDouble(
            object example,
            bool isNullable)
        {
            object @default = (double)0;

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

                if (exampleType != typeof(double))
                {
                    return Convert.ToDouble(example);
                }

                var exampleAsDouble = (double)example;
                return exampleAsDouble;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
