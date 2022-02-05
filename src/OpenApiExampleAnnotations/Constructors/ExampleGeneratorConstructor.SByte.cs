// <copyright file="ExampleGeneratorConstructor.SByte.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructSByte(
            object example,
            bool isNullable)
        {
            object @default = (sbyte)0;

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

                if (exampleType != typeof(sbyte))
                {
                    return Convert.ToSByte(example);
                }

                var exampleAsSByte = (sbyte)example;
                return exampleAsSByte;
            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
