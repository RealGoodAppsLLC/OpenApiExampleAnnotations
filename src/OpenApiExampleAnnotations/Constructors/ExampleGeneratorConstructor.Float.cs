// <copyright file="ExampleGeneratorConstructor.Float.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructFloat(
            object example,
            bool isNullable)
        {
            object @default = (float)0;

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

                if (exampleType != typeof(float))
                {
                    return Convert.ToSingle(example);
                }

                var exampleAsFloat = (float)example;
                return exampleAsFloat;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
