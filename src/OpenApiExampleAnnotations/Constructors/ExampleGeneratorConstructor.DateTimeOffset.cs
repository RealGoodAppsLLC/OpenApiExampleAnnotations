// <copyright file="ExampleGeneratorConstructor.DateTimeOffset.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructDateTimeOffset(
            object example,
            bool isNullable)
        {
            object @default = DateTimeOffset.MinValue;

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

                if (exampleType == typeof(string))
                {
                    var exampleAsString = (string)example;
                    return DateTimeOffset.Parse(exampleAsString);
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return @default;
        }
    }
}
