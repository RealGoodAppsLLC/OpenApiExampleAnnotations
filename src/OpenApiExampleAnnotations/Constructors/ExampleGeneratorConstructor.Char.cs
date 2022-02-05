// <copyright file="ExampleGeneratorConstructor.Char.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructChar(
            object example,
            bool isNullable)
        {
            object @default = (char)0;

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

                if (exampleType != typeof(char))
                {
                    return Convert.ToChar(example);
                }

                var exampleAsChar = (char)example;
                return exampleAsChar;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
