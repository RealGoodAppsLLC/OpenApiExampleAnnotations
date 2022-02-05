// <copyright file="ExampleGeneratorConstructor.Int.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructInt(
            object example,
            bool isNullable)
        {
            object @default = 0;

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

                if (exampleType != typeof(int))
                {
                    return Convert.ToInt32(example);
                }

                var exampleAsInt = (int)example;
                return exampleAsInt;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
