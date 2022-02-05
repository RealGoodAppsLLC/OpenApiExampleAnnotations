// <copyright file="ExampleGeneratorConstructor.Guid.cs" company="Real Good Apps">
// Copyright (c) Real Good Apps. All rights reserved.
// </copyright>

using System;

namespace RealGoodApps.OpenApiExampleAnnotations.Constructors
{
    internal static partial class ExampleGeneratorConstructor
    {
        internal static object ConstructGuid(
            object example,
            bool isNullable)
        {
            object @default = Guid.Empty;

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
                    return Guid.Parse(exampleAsString);
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
