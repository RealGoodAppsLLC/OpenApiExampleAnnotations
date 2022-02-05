// <copyright file="ExampleGeneratorConstructor.Decimal.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructDecimal(
            object example,
            bool isNullable)
        {
            object @default = (decimal)0;

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

                if (exampleType != typeof(decimal))
                {
                    return Convert.ToDecimal(example);
                }

                var exampleAsDecimal = (decimal)example;
                return exampleAsDecimal;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
