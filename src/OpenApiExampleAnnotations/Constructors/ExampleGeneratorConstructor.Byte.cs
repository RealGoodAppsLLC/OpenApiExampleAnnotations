// <copyright file="ExampleGeneratorConstructor.Byte.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructByte(
            object example,
            bool isNullable)
        {
            object @default = (byte)0;

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

                if (exampleType != typeof(byte))
                {
                    return Convert.ToByte(example);
                }

                var exampleAsByte = (byte)example;
                return exampleAsByte;

            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
